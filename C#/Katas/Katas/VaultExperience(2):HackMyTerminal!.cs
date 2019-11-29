using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class VaultExperience_2__HackMyTerminal_
{
    public static string HackMyTerminal(int passLength, string machineCode)
    {
        if(passLength == 0 || machineCode.Length == 0) return null;
        List<Match> passes = Regex.Matches(machineCode, "[a-zA-Z]+").ToList();
        passes = passes.Where(p => p.Length == passLength).ToList();
        List<Match> copyPasses = new List<Match>(passes.Count);
        passes.ForEach(p => copyPasses.Add(p));

        for (int i = 0; i < passes.Count; i++)
        {
            for (int j = i + 1; j < passes.Count; j++)
            {
                for (int e = 0; e < passLength - 1; e++)
                {
                    if (passes[i].ToString()[e] == passes[j].ToString()[e])
                    {
                        copyPasses.Remove(passes[i]);
                        copyPasses.Remove(passes[j]);
                        break;
                    }
                }
            }
        }
        return (copyPasses.Count == 1)?copyPasses[0].ToString():"SHUTDOWN";
    }
}