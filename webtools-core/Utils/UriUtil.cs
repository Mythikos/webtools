using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace WebToolsCore.Utils
{
    public static class UriUtil
    {
        private const char PATH_DELIMITER = '/';

        public static Uri ToAbsoluteUri(Uri parentUri, string relativeOrAbsoluteUri = null)
		{
            Uri cleanUri;
            Uri tempUri;

            // Do we have the parent uri?
            if (parentUri == null)
                throw new ArgumentNullException("parentUri");

            if (parentUri.IsAbsoluteUri == false)
                throw new ArgumentException("parentUri must be an absolute uri");

            cleanUri = new Uri(UriUtil.RemoveQuery(parentUri));

            // Do we even have the part to combine?
            if (string.IsNullOrWhiteSpace(relativeOrAbsoluteUri))
				return cleanUri;

            // Is the part to combine absolute?
            tempUri = new Uri(relativeOrAbsoluteUri, UriKind.RelativeOrAbsolute);
			if (tempUri.IsAbsoluteUri)
				return tempUri; // Just return that one then

            // We can assume we are looking at an absolute parent and a relative child, lets just generate a new uri now
            return new Uri(cleanUri, relativeOrAbsoluteUri);
        }

        public static string RemoveQuery(Uri uri)
            => (string.IsNullOrWhiteSpace(uri.Query)) ? HttpUtility.UrlDecode(uri.ToString()) : HttpUtility.UrlDecode(uri.ToString()).Replace(HttpUtility.UrlDecode(uri.Query), string.Empty);
    }
}
