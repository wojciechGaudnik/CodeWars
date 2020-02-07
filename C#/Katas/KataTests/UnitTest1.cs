using NUnit.Framework;
using System;
using System.Linq;
using System.Text;
using Katas;

public class SolutionTest
{
    [Test]
    public void SampleTests()
    {

        char[][] board =
        {
            new []{'E','A','R','A'},
            new []{'N','L','E','C'},
            new []{'I','A','I','S'},
            new []{'B','Y','O','R'}
        };

        var toCheck = new[] {
            "C",
            "EAR",
            "EARS",
            "BAILER",
            "RSCAREIOYBAILNEA",
            "CEREAL",
            "ROBES"

        };
        var expecteds = new[] { true, true, false, true, true, false, false };

        for (int i = 0; i < toCheck.Length; i++)
        {
            Assert.AreEqual(expecteds[i], new Boggle(DeepCopy(board), toCheck[i]).Check());
        }
    }

    private char[][] DeepCopy(char[][] arr)
    {
        return arr.Select(a =>
        {
            var target = new char[a.Length];
            Array.Copy(a, target, a.Length);
            return target;
        }).ToArray();
    }
}