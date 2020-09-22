using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebToolsCore.Objects.Forms;
using WebToolsCore.Objects.Net;
using WebToolsCore.Threading;
using WebToolsCore.Utils;

namespace WebToolsFuzzyLink
{
    public partial class frmMain : Form
    {
        private TaskQueue _taskQueue;
        private List<WebResponseItem> _webResponseItems;

        public frmMain()
        {
            InitializeComponent();

            this.Load += FrmMain_Load;
            this.processButton.Click += ProcessButton_Click;
            this.bruteForceRadioButton.Click += BruteForceRadioButton_Click;
            this.wordListRadioButton.Click += WordListRadioButton_Click;
            this.wordlistSelectButton.Click += WordlistSelectButton_Click;
            this.dataOutput.CellContentClick += DataOutput_CellContentClick;

            this._taskQueue = new TaskQueue();
            this._webResponseItems = new List<WebResponseItem>();
        }

        private void WordlistSelectButton_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "Text (*.txt) | *.txt";
            if (this.openFileDialog.ShowDialog() == DialogResult.OK && string.IsNullOrWhiteSpace(this.openFileDialog.FileName) == false)
                this.wordlistPathInput.Text = this.openFileDialog.FileName;
        }

        private void WordListRadioButton_Click(object sender, EventArgs e)
            => this.UIUpdateView();

        private void BruteForceRadioButton_Click(object sender, EventArgs e)
            => this.UIUpdateView();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.imgWorking.Image = WebToolsCore.Properties.Resources.working;
            this.UIUpdateView();

            // testing
            this.uriToFuzzInput.Text = "https://vincentlakatos.com/?p=<<FUZZ>>";
            this.wordlistPathInput.Text = @"D:\Repository\Visual Studio\webtools\webtools-fuzzylink\bin\wordlist.txt";
        }

        private async void ProcessButton_Click(object sender, EventArgs e)
        {
            //
            // Validate domain
            if (string.IsNullOrWhiteSpace(this.uriToFuzzInput.Text))
            {
                MessageUtil.ShowMessage("Uri must be provided.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.uriToFuzzInput.Text.IndexOf("<<FUZZ>>", StringComparison.OrdinalIgnoreCase) == -1)
            {
                MessageUtil.ShowMessage("Uri must contain at least one <<FUZZ>> tag.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.uriToFuzzInput.Text.StartsWith("http://", StringComparison.OrdinalIgnoreCase) == false && this.uriToFuzzInput.Text.StartsWith("https://", StringComparison.OrdinalIgnoreCase) == false)
            {
                MessageUtil.ShowMessage("Uri must start with the http or https schema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Uri.TryCreate(this.uriToFuzzInput.Text, UriKind.Absolute, out var startingUri);
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

            if (this.bruteForceRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(this.bruteForceCharacterSetInput.Text))
                {
                    MessageUtil.ShowMessage("Character set must be provided.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (this.bruteForceMinimumCharacters.Value < 1)
                {
                    MessageUtil.ShowMessage("Minimum character count can't be less than 1.");
                    return;
                }

                if (this.bruteForceMaximumCharacters.Value < 1)
                {
                    MessageUtil.ShowMessage("Maximum character count can't be less than 1.");
                    return;
                }

                if (this.bruteForceMinimumCharacters.Value > this.bruteForceMaximumCharacters.Value)
                {
                    MessageUtil.ShowMessage("Minimum character count can't be more than the maximum character count.");
                    return;
                }
            }
            else if (this.wordListRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(this.wordlistPathInput.Text))
                {
                    MessageUtil.ShowMessage("Wordlist path must be provided.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (File.Exists(this.wordlistPathInput.Text) == false)
                {
                    MessageUtil.ShowMessage("Wordlist path does not appear to lead to a valid file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //
            // Set is working
            this.UISetWorking(true, "Processing");

            //
            // Set task queue limits
            this._taskQueue.MaxConcurrency = (int)this.maxConcurrencyInput.Value;

            try
            {
                this.dataOutput.DataSource = null;
                this._webResponseItems.Clear();

                if (this.bruteForceRadioButton.Checked)
                {
                    this._webResponseItems = await BeginBruteForceFuzzing(startingUri, this.bruteForceCharacterSetInput.Text, (int)this.bruteForceMinimumCharacters.Value, (int)this.bruteForceMaximumCharacters.Value);
                }
                else if (this.wordListRadioButton.Checked)
                {
                    this._webResponseItems = await BeginWordlistFuzzing(startingUri, File.ReadAllLines(this.wordlistPathInput.Text).ToList());
                }

                this.dataOutput.DataSource = new SortableBindingList<WebResponseItem>(this._webResponseItems);
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

        private void DataOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && senderGrid.Columns[e.ColumnIndex].Name.Equals("viewDataGridViewButtonColumn", StringComparison.OrdinalIgnoreCase) && e.RowIndex >= 0)
            {
                frmViewResponse viewResponse = new frmViewResponse(this._webResponseItems[e.RowIndex]);
                viewResponse.Show();
            }
        }

        #region UI Helper Methods
        private void UIUpdateView()
        {
            if (this.bruteForceRadioButton.Checked)
            {
                this.wordListPanel.Visible = false;
                this.bruteForcePanel.Visible = true;
            }
            else if (this.wordListRadioButton.Checked)
            {
                this.bruteForcePanel.Visible = false;
                this.wordListPanel.Visible = true;
            }
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

        #region Helper Methods
        private async Task<List<WebResponseItem>> BeginBruteForceFuzzing(Uri uri, string characterSet, int minimumCharacters, int maximumCharacters)
        {
            throw new NotImplementedException();
            //return default;
        }

        private async Task<List<WebResponseItem>> BeginWordlistFuzzing(Uri uri, List<string> wordList)
        {
            var processTasks = new List<Task>();
            var webRequestResponses = new List<WebResponseItem>();

            foreach (string word in wordList)
            {
                processTasks.Add(new Task(() =>
                {
                    var responseItem = default(WebResponseItem);
                    var parsedUri = default(Uri);
                                       
                    try
                    {
                        Uri.TryCreate(uri.ToString().Replace("<<FUZZ>>", word), UriKind.Absolute, out parsedUri);
                        responseItem = WebUtil.GetDocumentContentWithDetail(parsedUri);
                    }
                    catch (Exception ex)
                    {
                        responseItem = new WebResponseItem();
                        responseItem.Uri = parsedUri;
                        responseItem.Error += ex.Message;
                    }
                    finally
                    {
                        webRequestResponses.Add(responseItem);
                    }
                }));
            }

            await this._taskQueue.Process(processTasks);

            return webRequestResponses;
        }
        #endregion
    }
}
