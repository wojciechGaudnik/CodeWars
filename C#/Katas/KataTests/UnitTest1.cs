using System;
using System.Linq;
using Katas;
using NUnit.Framework;

[TestFixture]
public class MedianTests
{
    [Test]
    public void SimpleTest0(){
        Warrior.ResetCompareCount();
        try {
            Warrior[] input = {
                new Warrior(3),
                new Warrior(1),
                new Warrior(2),
                new Warrior(4),
                new Warrior(5),
            };
            Warrior.ResetCompareCount();
            Assert.AreSame(input[0], kyu6SelectMedian.SelectMedian(input));
            Assert.LessOrEqual(Warrior.CompareCount, 6);
        } catch(Exception ex){
            Assert.Fail(ex.Message);
        }
    }

    [Test]
    public void SimpleTest1(){
        Warrior.ResetCompareCount();
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
        Warrior.ResetCompareCount();
        try {
            Warrior[] input = new Warrior[]{
                new Warrior(4),
                new Warrior(5),
                new Warrior(3),
                new Warrior(2),
                new Warrior(1),
            };
            Warrior.ResetCompareCount();
            var actual = kyu6SelectMedian.SelectMedian(input);
            Console.WriteLine(((Warrior)actual).m_internal + " <--- ((Warrior)actual).m_internal");
            Console.WriteLine((input[2]).m_internal + " <--- (input[3]).m_internal");
            Assert.AreSame(input[2], kyu6SelectMedian.SelectMedian(input));
            // Assert.LessOrEqual(Warrior.CompareCount, 6);
        } catch(Exception ex){
            Assert.Fail(ex.Message);
        }
    }

    [Test]
    public void SimpleTest3(){
        try {
            Warrior[] input = new Warrior[]{
                new Warrior(5),
                new Warrior(3),
                new Warrior(2),
                new Warrior(1),
                new Warrior(4),
            };
            Warrior.ResetCompareCount();
            var actual = kyu6SelectMedian.SelectMedian(input);
            Console.WriteLine(((Warrior)actual).m_internal + " <--- ((Warrior)actual).m_internal");
            Console.WriteLine((input[1]).m_internal + " <--- (input[1]).m_internal");
            Assert.AreSame(input[1], actual);
            // Assert.LessOrEqual(Warrior.CompareCount, 6);
        } catch(Exception ex){
            Assert.Fail(ex.Message);
        }
    }

    [Test]
    public void SimpleTest4(){
        try {
            Warrior[] input = new Warrior[]{
                new Warrior(2),
                new Warrior(5),
                new Warrior(4),
                new Warrior(3),
                new Warrior(1),
            };
            Warrior.ResetCompareCount();
            var actual = kyu6SelectMedian.SelectMedian(input);
            Assert.AreSame(input[3], actual);
            // Assert.LessOrEqual(Warrior.CompareCount, 6);
        } catch(Exception ex){
            Assert.Fail(ex.Message);
        }
    }
}


