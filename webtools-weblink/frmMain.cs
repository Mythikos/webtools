using HtmlAgilityPack;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebToolsCore.Extensions;
using WebToolsCore.Threading;
using WebToolsCore.Utils;
using WebToolsWebLink.Library.Entities;

namespace WebToolsWebLink
{
    public partial class frmMain : Form
    {
        private TaskQueue _taskQueue;
        private List<UriResourceItem> _uriResourceItems;

        public frmMain()
        {
            InitializeComponent();

            this.Load += FrmMain_Load;
            this.anaylyzeButton.Click += AnaylyzeButton_Click;

            this._taskQueue = new TaskQueue();
            this._uriResourceItems = new List<UriResourceItem>();
        }

        #region Control Methods
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //
            // Set working image
            this.imgWorking.Image = WebToolsCore.Properties.Resources.working;
        }

        private async void AnaylyzeButton_Click(object sender, EventArgs e)
        {
            //
            // Validate domain
            if (string.IsNullOrWhiteSpace(this.domainInput.Text))
            {
                MessageUtil.ShowMessage("Uri must be provided.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.domainInput.Text.StartsWith("http://", StringComparison.OrdinalIgnoreCase) == false && this.domainInput.Text.StartsWith("https://", StringComparison.OrdinalIgnoreCase) == false)
            {
                MessageUtil.ShowMessage("Uri must start with the http or https schema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Uri.TryCreate(this.domainInput.Text, UriKind.Absolute, out var startingUri);
            if (startingUri == default)
            {
                MessageUtil.ShowMessage("Uri is invalid and unable to be parsed.");
                return;
            }

            if (this.maxConcurrencyInput.Value < 1)
            {
                MessageUtil.ShowMessage("Thread count can't be less than 1.");
                return;
            }

            //
            // Set is working
            this.UISetWorking(true, "Processing");

            //
            // Set task queue limits
            this._taskQueue.MaxConcurrency = (int)this.maxConcurrencyInput.Value;

            try
            {
                //
                // Process the URI
                this._uriResourceItems = await BeginAnalysis(startingUri);

                //
                // Write the mappings to the database 
                this.linkMapTreeView.BeginUpdate();
                this.linkMapTreeView.Nodes.Clear(); // Empty the list
                foreach (UriResourceItem uriResourceItem in this._uriResourceItems)
                {
                    var parentNode = this.linkMapTreeView.Nodes.Add(uriResourceItem.Uri.ToString());
                    this.UIAssignLinkMapNodeContextMenu(parentNode);
                    foreach (Uri referencedUri in uriResourceItem.ReferencedUris)
                    {
                        if (referencedUri != null)
                        {
                            var childNode = parentNode.Nodes.Add(referencedUri.ToString());
                            this.UIAssignLinkMapNodeContextMenu(childNode);
                        }
                    }
                }
                this.linkMapTreeView.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageUtil.ShowMessage($"An unexpected error has occured: {ex.Message}.{Environment.NewLine}{ex.StackTrace}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.UISetWorking(false);
            }
        }
        #endregion

        #region Helper Methods
        private async Task<List<UriResourceItem>> BeginAnalysis(Uri startingUri)
        {
            var uriResourceItems = new List<UriResourceItem>();

            // Analyze the starting uri
            await Task.Factory.StartNew(() => uriResourceItems.Add(AnalyzeUri(startingUri)));

            // Did the user indicate a deep scan?
            if (this.recursiveCheckbox.Checked)
            {
                while (true)
                {
                    // Check for unanalyzed uris
                    var unanalyzedUris = await GetUnanalyzedUrisAsync(startingUri.Host, uriResourceItems);
                    if (unanalyzedUris.Count <= 0)
                        break;

                    // Build the task list
                    var analyzeUriTasks = new List<Task>();
                    unanalyzedUris.ForEach(x => analyzeUriTasks.Add(new Task(() => uriResourceItems.Add(AnalyzeUri(x)))));

                    // Execute the tasks
                    this.UISetWorking(true, $"Processing {analyzeUriTasks.Count} More URI(s){Environment.NewLine}({uriResourceItems.Count} Processed)");
                    await this._taskQueue.Process(analyzeUriTasks);
                }
            }

            return uriResourceItems.OrderBy(x => x.Uri.ToString()).ToList();
        }

        private UriResourceItem AnalyzeUri(Uri parentUri)
        {
            var uriResourceItem = new UriResourceItem(parentUri);
            if (uriResourceItem.SchemeType == WebToolsCore.Enumerations.UriSchemeType.HTTP || uriResourceItem.SchemeType == WebToolsCore.Enumerations.UriSchemeType.HTTPS)
            {
                //
                // Analyze elements that could contain hrefs
                var htmlDocumentContent = WebUtil.GetHtmlContent(uriResourceItem.CleanUri);
                if (htmlDocumentContent != default)
                {
                    // Analyze links
                    foreach (string attributeValue in htmlDocumentContent.GetAllNodes(new[] { "*[@href]", "*[@src]" }).GetAttributeValues(new[] { "href", "src" }))
                    {
                        try
                        {
                            var childUri = UriUtil.ToAbsoluteUri(uriResourceItem.CleanUri, attributeValue);
                            if (uriResourceItem.ReferencedUris.Contains(childUri) == false) // If we don't already have this uri, lets add it
                                uriResourceItem.ReferencedUris.Add(childUri);
                        }
                        catch { }
                    }

                    // Are we deep scanning?
                    if (this.deepScanCheckbox.Checked == true)
                    {
                        // Raw regex check
                        foreach (var match in RegexUtil.FindLinkMatches(htmlDocumentContent.Text))
                        {
                            try
                            {
                                var childUri = UriUtil.ToAbsoluteUri(uriResourceItem.CleanUri, match);
                                if (uriResourceItem.ReferencedUris.Contains(childUri) == false) // If we don't already have this uri, lets add it
                                    uriResourceItem.ReferencedUris.Add(childUri);
                            }
                            catch { }
                        }
                    }
                }
                else
                {
                    // The current link isnt a html parsable document
                    // Is deep scan enabled?
                    if (this.deepScanCheckbox.Checked == true)
                    {
                        var genericDocumentContent = WebUtil.GetDocumentContent(parentUri);
                        if (genericDocumentContent != default)
                        {
                            foreach (var match in RegexUtil.FindLinkMatches(genericDocumentContent))
                            {
                                try
                                {
                                    var childUri = UriUtil.ToAbsoluteUri(uriResourceItem.CleanUri, match);
                                    if (uriResourceItem.ReferencedUris.Contains(childUri) == false) // If we don't already have this uri, lets add it
                                        uriResourceItem.ReferencedUris.Add(childUri);
                                }
                                catch { }
                            }
                        }
                    }
                }
            }

            return uriResourceItem;
        }

        private async Task<List<Uri>> GetUnanalyzedUrisAsync(string host, List<UriResourceItem> uriResourceItems)
        {
            var result = new ConcurrentBag<Uri>();
            var checkTasks = new List<Task>();

            foreach (var uriResourceItem in uriResourceItems)
            {
                checkTasks.Add(new Task(() =>
                {
                    foreach (var referencedUri in uriResourceItem.ReferencedUris)
                    {
                        if (referencedUri.Host.Equals(host) && uriResourceItems.Any(x => x.Uri.Equals(referencedUri)) == false && result.Contains(referencedUri) == false)
                        {
                            result.Add(referencedUri);
                        }
                    }
                }));
            }
            await _taskQueue.Process(checkTasks);

            return result.ToList();
        }
        #endregion

        #region UI Helper Methods
        private void UIAssignLinkMapNodeContextMenu(TreeNode node)
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();

            var copyAction = new ToolStripMenuItem();
            copyAction.Text = "Copy";
            copyAction.Click += delegate { Clipboard.SetText(node.Text); };
            contextMenu.Items.Add(copyAction);

            node.ContextMenuStrip = contextMenu;
        }

        private void UISetWorking(bool isWorking, string message = null)
        {
            if (this.pnlWorking.InvokeRequired)
            {
                Invoke(new Action(() => UISetWorking(isWorking, message)));
                return;
            }

            this.lblWorking.Text = message ?? string.Empty;
            this.pnlWorking.Visible = isWorking;
        }
        #endregion

        #region Menu Strip Methods
        private void exportToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            // Is there anything to export?
            if (this._uriResourceItems.Count <= 0)
            {
                MessageUtil.ShowMessage("There is nothing to export at this time.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.saveFileDialog.Filter = ".csv|Comma-Delimited";
            this.saveFileDialog.FileName = "linkmap.csv";
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK && string.IsNullOrWhiteSpace(this.saveFileDialog.FileName) == false)
            {
                //
                // Extract as tab delimited
                foreach (var uriResourceItem in this._uriResourceItems)
                    File.AppendAllText(this.saveFileDialog.FileName, $"\"{uriResourceItem.CleanUri}\",\"{uriResourceItem.MimeType}\",\"{uriResourceItem.SchemeType}\"{Environment.NewLine}");
            }
        }

        private void exportToTabDelimitedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            // Is there anything to export?
            if (this._uriResourceItems.Count <= 0)
            {
                MessageUtil.ShowMessage("There is nothing to export at this time.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.saveFileDialog.Filter = ".txt|Tab-Delimited";
            this.saveFileDialog.FileName = "linkmap.txt";
            if (this.saveFileDialog.ShowDialog() == DialogResult.OK && string.IsNullOrWhiteSpace(this.saveFileDialog.FileName) == false)
            {
                //
                // Extract as tab delimited
                foreach (var uriResourceItem in this._uriResourceItems)
                    File.AppendAllText(this.saveFileDialog.FileName, $"{uriResourceItem.CleanUri}\t{uriResourceItem.MimeType}\t{uriResourceItem.SchemeType}{Environment.NewLine}");
            }
        }
        #endregion
    }
}
