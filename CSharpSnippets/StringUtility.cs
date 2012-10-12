using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpSnippets
{
    public class StringUtility
    {
        /// <summary>
        /// Combine url paths similar to Path.Combine but for urls, also corrects incorrect slash.
        /// </summary>
        /// <param name="url1"></param>
        /// <param name="url2"></param>
        /// <returns></returns>
        public static string UrlCombine(string url1, string url2)
        {
            if (String.IsNullOrWhiteSpace(url1))
                return url2;
            if (String.IsNullOrWhiteSpace(url2))
                return url1;
            url1 = url1.TrimEnd(@"/\".ToCharArray());
            url2 = url2.TrimStart(@"/\".ToCharArray());
            return String.Format("{0}/{1}", url1, url2);
        }
    }
}
