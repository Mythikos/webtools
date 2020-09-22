using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebToolsCore.Extensions
{
    public static class HtmlDocumentExt
    {
        public static List<HtmlNode> GetAllNodes(this HtmlDocument document, params string[] tagNames)
        {
            var result = new List<HtmlNode>();

            if (document != null)
            {
                try
                {
                    foreach (string tagName in tagNames)
                        foreach (HtmlNode node in document.DocumentNode.SelectNodes($"//{tagName}"))
                            result.Add(node);
                }
                catch
                {
                    result = new List<HtmlNode>();
                }
            }

            return result;
        }
    }
}
