using System;
using System.Linq;
using System.Numerics;

namespace Katas
{
    public class TEST
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
        //     var n = 10;
        //     Console.WriteLine(Math.Pow(dupa,n * 10 + 0) % 100);
        //     Console.WriteLine(Math.Pow(dupa,n * 10 + 1) % 100);
        //     Console.WriteLine(Math.Pow(dupa,n * 10 + 3) % 100);
        //     Console.WriteLine(Math.Pow(dupa,n * 10 + 5) % 100);
        //     Console.WriteLine(Math.Pow(dupa,n * 10 + 7) % 100);
        //     Console.WriteLine(Math.Pow(dupa,n * 10 + 9) % 100);
        // }

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