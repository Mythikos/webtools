using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebToolsCore.Utils
{
    public static class RegexUtil
    {
        public static List<string> FindLinkMatches(string content)
        {
            var result = new List<string>();
            var regex = new Regex("(?:\"|')(((?:[a-zA-Z]{1,10}://|//)[^\"'/]{1,}\\.[a-zA-Z]{2,}[^\"']{0,})|((?:/|\\.\\./|\\./)[^\"'><,;| *()(%%$^/\\\\\\[\\]][^\"'><,;|()]{1,})|([a-zA-Z0-9_\\-/]{1,}/[a-zA-Z0-9_\\-/]{1,}\\.(?:[a-zA-Z]{1,4}|action)(?:[\\?|/][^\"|']{0,}|))|([a-zA-Z0-9_\\-]{1,}\\.(?:php|asp|aspx|jsp|json|action|html|js|txt|xml)(?:\\?[^\"|']{0,}|)))(?:\"|')");

            if (string.IsNullOrWhiteSpace(content))
                return result;

            foreach (Match match in regex.Matches(content))
                result.Add(match.Value.Replace("\'", string.Empty).Replace("\"", string.Empty));

            return result;
        }
    }
}
