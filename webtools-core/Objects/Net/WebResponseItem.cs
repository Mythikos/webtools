using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebToolsCore.Objects.Net
{
    public class WebResponseItem
    {
        public Uri Uri { get; set; }
        public string Content { get; set; }
        public long Length { get; set; }
        public WebHeaderCollection Headers { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string Error {get;set;}

        public WebResponseItem()
        {
            this.Uri = default;
            this.Content = string.Empty;
            this.Length = default;
            this.Headers = default;
            this.StatusCode = default;
            this.Error = string.Empty;
        }

        public WebResponseItem(System.Net.HttpWebResponse response, Exception ex = null)
        {
            this.Uri = response.ResponseUri;
            this.Headers = response.Headers;
            this.Length = response.ContentLength;
            this.StatusCode = response.StatusCode;
            using (var streamReader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8))
                this.Content = streamReader.ReadToEnd();
            this.Error = ex == null ? string.Empty : ex.Message;
        }
    }
}
