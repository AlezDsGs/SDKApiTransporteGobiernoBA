using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace GobiernoApiTransporteSharp.Helpers
{
    internal static class ExtensionHelper
    {
        public static Uri AddQuery(this Uri uri, string name, string value)
        {
            var query = HttpUtility.ParseQueryString(uri.Query);

            query.Add(name, value);

            var uriBuilder = new UriBuilder(uri)
            {
                Query = query.ToString()
            };

            return uriBuilder.Uri;
        }
    }
}
