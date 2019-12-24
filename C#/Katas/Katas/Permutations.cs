using System;
using System.Collections.Generic;
using System.Linq;

public class Permutations
{
    public static List<string> SinglePermutations(string s)
    {
        int n = s.Length;
        HashSet<string> permutations = new HashSet<string>();
        permute(s, 0, n-1, ref permutations);
        return permutations.ToList();
    }

    private static void permute(String str, int l, int r, ref HashSet<string> permutations)
    {
        if (l == r)
        {
            permutations.Add(str);
            Console.WriteLine(str);
        }
        else
        {
            for (var i = l; i <= r; i++)
            {
                str = swap(str, l, i);
                permute(str, l + 1, r, ref permutations);
                str = swap(str, l, i);
            }
        }
    }

    private static String swap(String a, int i, int j)
    {
        var charArray = a.ToCharArray();
        var temp = charArray[i];
        charArray[i] = charArray[j];
        charArray[j] = temp;
        var s = new string(charArray);
        return s;
    }
}

