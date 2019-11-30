using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class Basics05_TextSearch
    {
        public List<int> searchText(string text, string pattern, bool behind)
        {
            if (text.Length == 0 | pattern.Length == 0)
            {
                return new List<int>();
            }
            return ((behind)?
                Regex.Matches(text, pattern):
                Regex.Matches(text, @"(?=" + pattern + ")")).
                Select(e => e.Index).ToList();
        }
    }
}