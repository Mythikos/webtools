using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebToolsCore.Enumerations;
using WebToolsCore.Utils;

namespace WebToolsWebLink.Library.Entities
{
    internal class UriResourceItem
    {
        public UriSchemeType SchemeType { get; private set; }
        public string MimeType { get; private set; }
        public string Query { get; private set; }
        public Uri CleanUri { get; private set; }
        public Uri Uri { get; private set; }
        public List<Uri> ReferencedUris { get; private set; }

        public UriResourceItem(Uri uri)
        {
            this.Uri = uri;
            this.CleanUri = new Uri(UriUtil.RemoveQuery(uri));
            this.MimeType = MimeMapping.GetMimeMapping(Path.GetFileName(uri.AbsolutePath));
            this.Query = uri.PathAndQuery;
            switch (Uri.Scheme.ToLower())
            {
                case "http":
                    this.SchemeType = UriSchemeType.HTTP;
                    break;
                case "https":
                    this.SchemeType = UriSchemeType.HTTPS;
                    break;
                case "ftp":
                    this.SchemeType = UriSchemeType.FTP;
                    break;
                case "telnet":
                    this.SchemeType = UriSchemeType.TELNET;
                    break;
                case "tel":
                    this.SchemeType = UriSchemeType.TEL;
                    break;
                case "mailto":
                    this.SchemeType = UriSchemeType.MAILTO;
                    break;
                default:
                    this.SchemeType = UriSchemeType.Unknown;
                    break;
            }
            this.ReferencedUris = new List<Uri>();
        }
    }
}
