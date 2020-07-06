using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu5MoleculeToAtoms
    {
        public static Dictionary<string, int> ParseMolecule(string formula)
        {
            formula = formula
                .Replace('[', '(')
                .Replace(']', ')')
                .Replace('{', '(')
                .Replace('}', ')');

            var dictionary = new Dictionary<string, int>();
            var pattern = "\\((?>\\((?<c>)|[^()]+|\\)(?<-c>))*(?(c)(?!))\\)\\d*";
            var regex = new Regex(pattern);

            ParseAll(formula, regex, dictionary);

            return dictionary;
        }

        private static void ParseAll(string formulaChain, Regex regex, Dictionary<string, int> dictionary, int m = 1)
        {
            if (regex.IsMatch(formulaChain))
            {
                foreach (Match one in regex.Matches(formulaChain))
                {
                    var split = one.Value.Split(")");
                    if (!int.TryParse(split[^1], out var multiplier)) multiplier = 1;
                    var nestedFormula = one.ToString().Substring(1, one.Value.Length - multiplier.ToString().Length - 1);
                    formulaChain = regex.Replace(formulaChain, "", 1);
                    if (!formulaChain.Contains('(')) ParseAtomsSimple(formulaChain, dictionary, m);
                    ParseAll(nestedFormula, regex, dictionary, multiplier * m);
                }
            } else ParseAtomsSimple(formulaChain, dictionary, m);
        }

        private static void ParseAtomsSimple(string atoms, Dictionary<string, int> dictionary, int multiplier = 1)
        {
            foreach (Match one in (new Regex("[A-Z][a-z]*\\d*")).Matches(atoms))
            {
                var atom = (new Regex("[A-Z][a-z]*")).Match(one.Value).ToString();
                if (!int.TryParse((new Regex("\\d+"))
                    .Match(one.ToString()).ToString(), out var count)) count = 1;
                if (dictionary.ContainsKey(atom)) dictionary[atom] += count * multiplier;
                else dictionary.Add(atom, count * multiplier);
            }
        }
    }
}