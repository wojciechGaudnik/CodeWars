using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class kyu6TheEnigmaMachinePart1ThePlugboard
    {
        Dictionary<char, char> ce = new Dictionary<char, char>();
        Dictionary<char, char> de = new Dictionary<char, char>();

        public kyu6TheEnigmaMachinePart1ThePlugboard(string wires = "") {
            if(
                wires.Length % 2 != 0 ||
                wires.Length > 10 ||
                wires.Select(c => c).ToHashSet().Count != wires.Length) throw new Exception();

            for (var i = 0; i < wires.Length; i += 2)
            {
                ce.Add(wires[i], wires[i + 1]);
                de.Add(wires[i + 1], wires[i]);
            }

        }
        public char process(char c) {
            if(ce.ContainsKey(c)) return ce[c];
            if(de.ContainsKey(c)) return de[c];
            return c;
        }
    }
}