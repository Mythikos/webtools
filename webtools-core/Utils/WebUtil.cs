using HtmlAgilityPack;
using System;
using System.Text;
using WebToolsCore.Objects.Net;

namespace WebToolsCore.Utils
{
    public static class WebUtil
    {
        public static HtmlDocument GetHtmlContent(Uri uri)
        {
            try
            {
                var webHtml = new HtmlWeb();
                return webHtml.Load(uri.ToString());
            }
            catch
            {
                return default;
            }

        }

        public static string GetDocumentContent(Uri uri)
        {
            string result;

            try
            {
                var request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(uri);
                var response = (System.Net.HttpWebResponse)request.GetResponse();
                using (var streamReader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    result = streamReader.ReadToEnd();
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }

        public static WebResponseItem GetDocumentContentWithDetail(Uri uri)
        {
            WebResponseItem result;

            try
            {
                var request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(uri);
                var response = (System.Net.HttpWebResponse)request.GetResponse();
                result = new WebResponseItem(response);
            }
            catch(System.Net.WebException ex)
            {
                result = new WebResponseItem((System.Net.HttpWebResponse)ex.Response, ex);
            }
            catch (Exception ex)
            {
                result = new WebResponseItem();
                result.Uri = uri;
                result.Error = ex.Message;
            }

            return result;
        }
    }
}
