using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebToolsCore.Extensions
{
    public static class HtmlNodeCollectionExt
    {
        public static List<string> GetAttributeValues(this List<HtmlNode> collection, params string[] attributeNames)
        {
            var attributeValues = new List<string>();

            if (collection != null)
            {
                try
                {
                    foreach (HtmlNode node in collection)
                    {
                        foreach (string attributeName in attributeNames)
                        {
                            var attributeValue = node.GetAttributeValue(attributeName, string.Empty);
                            if (string.IsNullOrWhiteSpace(attributeValue) == true)
                                continue;

                            attributeValues.Add(attributeValue);
                        }
                    }
                }
                catch
                {
                    attributeValues = new List<string>();
                }
            }

            return attributeValues;
        }
    }
}
