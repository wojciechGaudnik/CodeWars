using System;
using Katas;
using NUnit.Framework;

[TestFixture]
public class Examples
{
    [Test,Description("5 Example Tests")]
    public static void ExampleTests()
    {
        var example_test = new string[5][]{
            new string[]{
                "000001",
                "010010",
                "101001",
                "010100",
                "001010",
                "010000",
                "100010",
                "010100",},
            new string[]{
                "01000100",
                "00101000",
                "01010101",
                "10000000",
                "10000100",
                "10001000",
                "00001010",
                "01001000"},
            new string[]{
                "00000100",
                "01000101",
                "00001001",
                "10000010",
                "01001000",
                "00101010",
                "10001010",
                "10101001"},
            new string[]{
                "00010000",
                "10000100",
                "10100010",
                "10010100",
                "10101001",
                "01000000",
                "01000100",
                "00100001",
                "00000100",
                "01000010"},
            new string[]{
                "0010001010",
                "1001000000",
                "0100010010",
                "0101001000",
                "0100100001",
                "1001001010",
                "0100101010",
                "1001001000",
                "1000101001",
                "0001000100"}
        };

        var example_sols = new int[5][]{
            new int[]{6,3,2,1,0,5,4},
            new int[]{3,2,0,6,4,1,8,5,7},
            new int[]{2,1,0,3,5,4,7,8,6},
            new int[]{0,4,1,3,7,2,5,6,8},
            new int[]{3,0,1,2,4,7,6,8,5,9,10}
        };

        for (int i = 0; i < 5; i++){
            Assert.That(Banzai.Amidakuji(example_test[i]),Is.EqualTo(example_sols[i]));}
    }
}