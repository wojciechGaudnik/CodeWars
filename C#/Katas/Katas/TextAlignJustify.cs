using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class TextAlignJustify
    {
        public static string Justify(string str, int len)
        {
            if (str == null) return "";
            var words = Regex.Split(str, "\\s+").Select(w => w + " ").ToArray();
            IList<string> lines = new List<string>();
            IList<string> line = new List<string>();

            var totalLengthLine = 0;
            for (var i = 0; i < words.Length; i++)
            {
                totalLengthLine += words[i].Length;
                if (totalLengthLine - 1> len)
                {
                    var different = len - (totalLengthLine - words[i].Length) + 1;
                    while (different > 0)
                    {
                        if (line.Count == 1)
                        {
                            lines.Add($"{line[0].Trim()}\n");
                            line.Clear();
                            line.Add(words[i]);
                            totalLengthLine = words[i].Length;
                            break;
                        }
                        if (line.Count > 1)
                        {
                            for (var j = 0; j < line.Count - 1 && different > 0; j++)
                            {
                                line[j] = line[j] + " ";
                                different--;
                            }
                        }
                        if (different == 0)
                        {
                            lines.Add(string.Join("", line).Trim() + "\n");
                            totalLengthLine = words[i].Length;
                            line.Clear();
                            line.Add(words[i]);
                        }
                    }
                }
                else if (totalLengthLine - 1 < len)
                {
                    line.Add(words[i]);
                }
                else if (totalLengthLine - 1 == len)
                {
                    line.Add(words[i]);
                    lines.Add(string.Join("", line).Trim() + "\n");
                    totalLengthLine = 0;
                    line.Clear();
                }
                if (i == words.Length - 1)
                {
                    lines.Add(string.Join("", line).Trim());

                }
            }
            return string.Join("", lines).Trim();
        }
    }
}