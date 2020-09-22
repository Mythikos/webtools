using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebToolsCore.Objects.Net;

namespace WebToolsFuzzyLink
{
    public partial class frmViewResponse : Form
    {
        private WebResponseItem _webResponseItem;

        public frmViewResponse(WebResponseItem webResponseItem)
        {
            InitializeComponent();

            this.Load += FrmViewRequest_Load;

            this._webResponseItem = webResponseItem;
        }

        private void FrmViewRequest_Load(object sender, EventArgs e)
        {
            if (this._webResponseItem != null)
            {
                //
                // Show additional data
                if (this._webResponseItem.Uri != null)
                    this.additionalDataText.AppendText($"Uri: {this._webResponseItem.Uri.ToString()}{Environment.NewLine}");

                this.additionalDataText.AppendText($"Response Code: {this._webResponseItem.StatusCode} ({this._webResponseItem.StatusCode.ToString()}){Environment.NewLine}");

                if (string.IsNullOrWhiteSpace(this._webResponseItem.Error) == false)
                    this.additionalDataText.AppendText($"Error: {this._webResponseItem.Error}{Environment.NewLine}");

                //
                // Show headers
                if (this._webResponseItem.Headers != null)
                foreach (var key in this._webResponseItem.Headers.AllKeys)
                    this.headerText.AppendText($"{key}: {this._webResponseItem.Headers[key]}{Environment.NewLine}");

                //
                // Show content
                if (string.IsNullOrWhiteSpace(this._webResponseItem.Content) == false)
                    this.contentText.AppendText(this._webResponseItem.Content);
            }
        }
    }
}
