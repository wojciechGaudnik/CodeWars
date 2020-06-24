using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Threading;

namespace Katas
{
    public class kyu3LastDigitOfaHugeNumber
    {
        // public static void Main(string[] args)
        // {
        //     https://www.codewars.com/kata/5518a860a73e708c0a000027
        //     // BigInteger n = 2;
        //     // BigInteger nn = 1;
        //     // BigInteger m = 3;
        //     // BigInteger mm = 1;
        //     // BigInteger x = 4;
        //     // BigInteger xx = 1;
        //     // BigInteger y = 5;
        //     // BigInteger yy = 1;
        //     // for (var i = 0; i < 10; i++)
        //     // {
        //     //     nn *= n;
        //     //     mm *= m;
        //     //     xx *= x;
        //     //     yy *= y;
        //     //     Console.WriteLine(nn + " " + mm + " " + xx + " " + yy);
        //     // }
        //     // int[] array = new int[] {3,4,2};
        //     // Console.WriteLine(BigInteger.Pow(9, 81));
        //     // Console.WriteLine(9 * 9);
        //
        //     for (var i = 10; i < 200; i += 10)
        //     {
        //         Console.WriteLine((i + 5) % 4);
        //     }
        //
        //     Console.WriteLine(3124 * 5432);
        //     Console.WriteLine(472 % 100);
        //     Console.WriteLine(MultipleLastTwoDigits(3124, 5432));
        //     Console.WriteLine(MultipleLastTwoDigits( 5432,3124));
        //
        //     int[] array = new int[] {3,4,2};
        //     Console.WriteLine(findMy(array));
        //     Console.WriteLine("-------------");
        //     var dupa = 23;
        //     for (var i = 0; i < 100; i += 1)
        //     {
        //         Console.WriteLine(Math.Pow(dupa, i));
        //         // dupa += i;
        //     }
        //
        //     dupa = 25;
        //
        //     Console.WriteLine("----------------------");
        //     // var n = new BigInteger(13);
        //     // var e = 14;
        //     // var l = BigInteger.Pow(n, e).ToString();
        //     // Console.WriteLine(l.Substring(l.Length - 2,2));
        //     // for (var i = 0; i < 10000; i += 100)
        //     // {
        //     //     l = BigInteger.Pow(n, e).ToString();
        //     //     Console.WriteLine("n = " + n + "  e = " + e + "   "  + l.Substring(l.Length - 2,2));
        //     //     e += i;
        //     //
        //     // }
        //
        //
        //
        //     Console.WriteLine("----------------------");
        //     var watch = new Stopwatch();
        //     watch.Start();
        //     Console.WriteLine(If1(31, 76));
        //     Console.WriteLine(If1(41, 38));
        //     Console.WriteLine(If1(71, 87));
        //     Console.WriteLine(If1(91, 94));
        //
        //
        //     Console.WriteLine(BigInteger.Pow(new BigInteger(87), 2));
        //     Console.WriteLine(BigInteger.Pow(new BigInteger(69), 2));
        //
        //
        //     Console.WriteLine(If3or7or9(87, 73));
        //     Console.WriteLine(If3or7or9(79, 64));
        //     Console.WriteLine(If3or7or9(7, 2008));
        //
        //     Console.WriteLine(IfEven(62, 48).Equals(96));
        //     Console.WriteLine(IfEven(2, 34).Equals(84));
        //     // Console.WriteLine(IfEven(4,2).Equals(16));
        //     Console.WriteLine(IfEven(4,2));
        //     Console.WriteLine(If5(135, 123));
        //
        //     Console.WriteLine(LastDigit(new []{3,4,2}));
        //     Console.WriteLine(LastDigit(new []{937640,767456,981242}));
        //     Console.WriteLine(LastDigit(new []{123232,694022,140249}));
        //     Console.WriteLine(LastDigit(new []{499942,898102,846073}));
        //     watch.Stop();
        //     Console.WriteLine(watch.ElapsedMilliseconds + "<--- time");
        //
        //
        // }

        // private static int IfEven2(int n, int e)
        // {
        //     var list = new LinkedList<int>();
        //     while (n % 2 == 0 )
        //     {
        //
        //         n / 2;
        //
        //     }
        //
        //     return 666;
        // }

        public static int LastDigit(int[] arr)
        {
            var e = (arr.Length - 1) % 100;
            var n = 0;
            for (var i = arr.Length - 2; i >= 0; i--)
            {
                n = arr[i];
                if (n <= 99)  n *= 100;
                if (e <= 99) e *= 100;
                if (n % 10 == 1)
                {
                    e = If1(n, e);
                    continue;
                }

                if (n % 10 == 3 || n % 10 == 7 || n % 10 == 9)
                {
                    e = If3or7or9(n, e);
                    continue;
                }
                if ((n % 10) % 2 == 0)
                {
                    e = IfEven(n, e);
                    continue;
                }
                if (n % 10 == 5)
                {
                    e = If5(n, e);
                    continue;
                }

            }
            return n % 10;
        }

        private static int If1(int n, int e)
        {
            return ((((n - n % 10) / 10) * e % 10) % 10) * 10 + 1; //todo check if parse is faster ?
        }

        private static int If3or7or9(int n, int e)
        {
            var list = new LinkedList<int>();
            while (n % 10 != 1)
            {
                if(e % 2 == 1)
                {
                    e--;
                    list.AddFirst(n); //todo check if % 100 will be ok
                }
                e /= 2;
                n = (int) (Math.Pow(n, 2) % 100);
            }
            return (int) (list?.Aggregate(1, (a, b) => a * b) * If1(n, e)) % 100;
        }

        public static int IfEven(int n, int e)
        {
            var list = new LinkedList<int>();
            list.AddFirst(If1(n / 2, e));
            list.AddFirst((int) Math.Pow(2, e % 10));
            e -= e % 10;
            list.AddFirst((int) Math.Pow(24, e / 10) % 100);
            return list.Aggregate(1, (a, b) => a * b) % 100;
        }

        private static int If5(int n, int e)
        {
            n -= n % 10;
            n /= 10;
            e %= 10;
            return (n % 2 == 1 && e % 2 == 1) ? 75 : 25;
        }


        static int findMy(int[] arr)
        {
            var first = arr[0];
            arr[0] = 1;
            var exponent = arr.Aggregate(MultipleLastTwoDigits);
            Console.WriteLine(exponent);



            return 666;
        }

        private static int MultipleLastTwoDigits(int a, int b)
        {
            return ((a % 100) * (b % 100)) % 100;  //todo one % can remove because return is 2 digits
        }
    }
}