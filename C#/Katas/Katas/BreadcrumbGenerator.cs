using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Katas
{
    public class BreadcrumbGenerator
    {
        private static String HREF = "<a href=\"#LINK#\">#LINK_TEXT#</a>";
        private static String SPAN = "<span class=\"active\">#SPAN_TEXT#</span>";
        private static string[] Excluded = {"the", "of", "in", "from", "by", "with", "and", "or", "for", "to", "at", "a"};

        public static string GenerateBC(string url, string separator)
        {
            url = url.Substring(url.IndexOf("."));
            url = Regex.Split(url.Substring(url.IndexOf("/") + 1), "\\?|#|index\\.")[0];

            if (url.Trim().Equals("") || !url.Contains("/")) return SPAN.Replace("#SPAN_TEXT#", "HOME");
            if (url.EndsWith("/")) url = url.Substring(0, url.Length - 1);

            String home = HREF.Replace("#LINK#", "/").Replace("#LINK_TEXT#", "HOME") + separator;
            String[] urlParts = url.Split("/");
            String span = SPAN.Replace("#SPAN_TEXT#", Parse(urlParts[urlParts.Length - 1].Split(".")[0]));

            urlParts = urlParts.Select(u => u).Take(urlParts.Length - 1).ToArray();
            if (urlParts.Length == 0) return home + span;
            String href = "";
            StringBuilder answer = new StringBuilder();
            answer.Append(home);
            for (int i = 0; i < urlParts.Length; i++)
            {
                StringBuilder link = new StringBuilder();
                for (int j = 0; j <= i; j++) link.Append(urlParts[j]).Append("/");
                String linkText = Parse(urlParts[i]);
                href = HREF
                           .Replace("#LINK#", "/" + link)
                           .Replace("#LINK_TEXT#", linkText) + separator;
                answer.Append(href);
            }

            answer.Append(span);
            return answer.ToString();
        }

        private static String Parse(String text)
        {
            return (text.Length >= 30)
                ? string.Join("", text
                    .Replace("/", "")
                    .Split("-")
                    .Where(s => !Excluded.Contains(s))
                    .Select(s => "" + s[0]).ToArray()).ToUpper()
                : text.Replace("-", " ").ToUpper();
        }
    }
}
