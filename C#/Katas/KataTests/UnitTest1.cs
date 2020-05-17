using System;
using System.Linq;
using Katas;
using NUnit.Framework;
//
// public interface IWarrior {
//     // a.IsBetter(b) returns true if and only if
//     // warrior a is no worse than warrior b, i.e. a>=b
//     bool IsBetter(IWarrior other);
// }
//
//
// public class Warrior : IWarrior {
//     private int m_internal;
//
//     public static int CompareCount {get; private set;}
//
//     public Warrior(int rank=0){
//         m_internal = rank;
//     }
//
//     public bool IsBetter(IWarrior other){
//         ++CompareCount;
//         if(other == null || !(other is Warrior)) return false;
//         return m_internal >= (other as Warrior).m_internal;
//     }
//
//     public static void ResetCompareCount(){
//         CompareCount = 0;
//     }
// }
//
[TestFixture]
public class MedianTests
{
    [Test]
    public void SimpleTest(){
        try {
            Warrior[] input = new Warrior[]{
                new Warrior(1),
                new Warrior(4),
                new Warrior(5),
                new Warrior(3),
                new Warrior(2),
            };
            Warrior.ResetCompareCount();
            Assert.AreSame(input[3], kyu6SelectMedian.SelectMedian(input));
            Assert.LessOrEqual(Warrior.CompareCount, 6);
        } catch(Exception ex){
            Assert.Fail(ex.Message);
        }
    }

    [Test]
    public void SimpleTest2(){
        try {
            Warrior[] input = new Warrior[]{
                new Warrior(4),
                new Warrior(5),
                new Warrior(3),
                new Warrior(2),
                new Warrior(1),
            };
            Warrior.ResetCompareCount();
            Assert.AreSame(input[3], kyu6SelectMedian.SelectMedian(input));
            Assert.LessOrEqual(Warrior.CompareCount, 6);
        } catch(Exception ex){
            Assert.Fail(ex.Message);
        }
    }
}