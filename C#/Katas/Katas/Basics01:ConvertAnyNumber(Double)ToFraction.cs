using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Rationals;

namespace Katas
{
    public class Basics01_ConvertAnyNumber_Double_ToFraction
    {
        static void Main(string[] args)
        {
//            Console.WriteLine(game(-2.5));
//            Console.WriteLine(game(0.3333333333333));
//            Console.WriteLine(game2(1.618103448275862));
//            Console.WriteLine(game2(0.5));
//            Console.WriteLine(GCD(5, 10));
//            Console.WriteLine();
//            0.000000001
//            0.618103448275862
//            ulong a = 618103448275862;
//            ulong b = 1000000000000000;
//            Console.WriteLine(a / GCD(a, b) + " " + b / GCD(a, b));

//            Console.WriteLine((decimal)a/b);
//            Console.WriteLine(0.618103448275862 / 0.000000001);
//            Console.WriteLine(GCD(a, b));
//            Console.WriteLine(a / GCD(a, b) + " " + b / GCD(a, b));
//            Console.WriteLine(717.0/1160);
//            Console.WriteLine(game2(0.618103448275862));
//            Console.WriteLine(game2(0.5));
//            game4(0.5);
//            game4(-2.5);
//            Console.WriteLine(game4(2));
//            game4(0.61810344);
//            Console.WriteLine(GCD(a,b));
//            Console.WriteLine(GreatestCommonDivisor((uint) a, (uint) b));
//            Console.WriteLine(a / GCD(a, b) + " " + b / GCD(a, b));
//            Console.WriteLine(a / GreatestCommonDivisor((uint) a, (uint) b) + " " + b / GreatestCommonDivisor((uint) a, (uint) b));
//            Console.WriteLine(ConvertMy((decimal) 0.618103448275862));

//            Console.WriteLine(717.0/1160 - 0.618103448275862);
//            Console.WriteLine(Rational.Approximate(0.618_103_448_275_862, 0.000_000_001));
//            Console.WriteLine(Rational.Approximate(0.66666666666, 0.000000001));

            List<long> cf = new List<long>();
//            long a = 1_000_000_000_000_000;
//            long b =   618_103_448_275_862;
            long a = 89;
            long b = 37;
            long f = 0;
            long temp = 0;

            cf.Add(0);
            Console.WriteLine("-----------");
            f = a / b;
            cf.Add(f);
            a -= (f * b);
            Console.WriteLine(f);
            Console.WriteLine(a);
            Console.WriteLine(b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("-----------");
            f = a / b;
            cf.Add(f);
            a -= (f * b);
            Console.WriteLine(f);
            Console.WriteLine(a);
            Console.WriteLine(b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("-----------");
            f = a / b;
            cf.Add(f);
            a -= (f * b);
            Console.WriteLine(f);
            Console.WriteLine(a);
            Console.WriteLine(b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("-----------");
            f = a / b;
            cf.Add(f);
            a -= (f * b);
            Console.WriteLine(f);
            Console.WriteLine(a);
            Console.WriteLine(b);
            temp = a;
            a = b;
            b = temp;
//            if(b == 0) return;
            Console.WriteLine("-----------------------------");
            Console.WriteLine(cf[0]);
            Console.WriteLine(cf[0] + 1.0/cf[1]);
            Console.WriteLine(cf[0] + (1.0/(cf[1] + 1.0/cf[2])));


            Console.WriteLine(Rational.Approximate(0.324, 0.000000001));
            Console.WriteLine(-12.234234 / 0.000000001);
            string number = Convert.ToString(-0.618103448275862);
            string[] numberSpited = Regex.Split(number, ".");
            Console.WriteLine("game666 -------------------------------------------------");
            Console.WriteLine(Game666(0.618103448275862));
//            Console.WriteLine(Game666(0.5));
//            Console.WriteLine(Game666(0.324));
//            Console.WriteLine(Rational.Approximate(0.618103448, 0.000000001));
        }
//        0.618103448//275862
//        0.000000001
        public static string Game666(double n)
        {
            if(Math.Abs(n % 1) < 0.000000001) return Convert.ToString(n, CultureInfo.InvariantCulture);
            string number = Convert.ToString(n, CultureInfo.CurrentCulture);
            string[] numberSpited = Regex.Split(number, "\\.");
            if(numberSpited[1].Length > 9) numberSpited[1] = numberSpited[1].Substring(0, 9);
            long whole = long.Parse(numberSpited[0]);
            long a = long.Parse(numberSpited[1]);
            long b = (long)Math.Pow(10, numberSpited[1].Length);
            long temp = 0;
            ArrayList cf = new ArrayList();
            while (b != 0 && cf.Count < 100)
            {
                long f = a / b;
                cf.Add(f);
                a -= (f * b);
                temp = a;
                a = b;
                b = temp;
            }

            foreach (var ncf in cf)
            {
                Console.WriteLine(ncf + " <---- ");
            }

            long numerator = 0;
            long denominator = 0;
            int i = 1;
            while (numerator < 2000 && denominator < 2000)
            {
                Fraction(cf.GetRange(0, i), out numerator, out denominator);
                Console.WriteLine(numerator + " " + denominator);
                if(++i > cf.Count) break;
            }



            return "";
        }

        public static void Fraction(ArrayList cf, out long n, out long d)
        {
            n = 1;
            d = (long)cf[^1];
            long temp = 0;
            for (int i = cf.Count - 2; i > 0; i--)
            {
                n += (long)cf[i] * d;
                temp = n;
                n = d;
                d = temp;
            }

            Console.WriteLine("asdf");
        }


        public static string game4(double n)
        {
            if(Math.Abs(n % 1) < 0.000000001) return Convert.ToString(n, CultureInfo.CurrentCulture);
            bool isNegative = n < 0;
            n = Math.Abs(n);
            Decimal firstNumber = (Decimal)n;
            Decimal secondNumber = Decimal.Floor((decimal)n);
            Decimal thirdNumber = firstNumber - secondNumber;
            int times = 0;

            while (thirdNumber % 1 != 0)
            {
                thirdNumber *= 10;
                times++;
            }


            int numerator = Convert.ToInt32(thirdNumber);
            int denominator = Convert.ToInt32(Math.Pow(10, times));
            int i = 2;


            while (numerator >= i && denominator >= i)
            {
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(secondNumber);
            Console.WriteLine(numerator);
            Console.WriteLine(denominator);
            return "";

        }


//        public static string game4(double n)
//        {
//            Decimal firstNumber = (Decimal)n;
//            Decimal secondNumber = Decimal.Floor((decimal)n);
//            Decimal thirdNumber = firstNumber - secondNumber;
//            int times = 0;
//
//            while (thirdNumber % 1 != 0)
//            {
//                thirdNumber = thirdNumber * 10;
//                times++;
//            }
//
//            int denominator = Convert.ToInt32(Math.Pow(10, times));
//            int numerator = Convert.ToInt32(thirdNumber);
//            int i = 2;
//
//            while (numerator >= i && denominator >= i)
//            {
//                if (numerator % 1 == 0 && denominator % i == 0)
//                {
//                    numerator /= i;
//                    denominator /= i;
//                }
//                else
//                {
//                    i++;
//                }
//            }
//
//            Console.WriteLine(secondNumber);
//            Console.WriteLine(numerator);
//            Console.WriteLine(denominator);
//            return "";
//
//        }

        public static string game2(double n)
        {
            double firstNumber = n;
            ulong secondNumber = (ulong) n;
            decimal thirdNumber = (decimal)firstNumber - secondNumber;
            var times = 0;
            while (thirdNumber % 1 >= (decimal) 0.000000001)
            {
                thirdNumber *= 10;
                times++;
            }

//            Console.WriteLine(times);
//            Console.WriteLine(firstNumber);  //<---  przed przekształceniem
//            Console.WriteLine(secondNumber); //<--- całkowita !!!
//            Console.WriteLine(thirdNumber); //<--- część ułamkowa

            ulong numerator = (ulong)thirdNumber;
            ulong denominator = (ulong)Math.Pow(10, times);

            var test = LCM(numerator, denominator);

            Console.WriteLine(GCD(numerator, denominator));
            Console.WriteLine(LCM(numerator, denominator));
            Console.WriteLine(numerator / test);
            Console.WriteLine(denominator / test);
//            Console.WriteLine(denominator);
//            Console.WriteLine(numerator);
//            Console.WriteLine(GCD((ulong)denominator, (ulong)numerator));
            return "";
        }

        static ulong GCD(ulong a, ulong b)
        {
            if (a == 0)
                return b;
            return GCD(b % a, a);
        }

        static ulong LCM(ulong a, ulong b)
        {
            return (a * b) / GCD(a, b);
        }


        public static string game(double n)
        {
//            if (n == 0) return "[0]";
//            if (n % 2 == 0) return ($"[{n * (n / 2)}]");
            double firstNumber = n;
            double secondNumber = Math.Ceiling(n);
            double thirdNumber = firstNumber - secondNumber;
            long times = 0;
            while (Math.Abs(thirdNumber % 1) >= 0.000000001)
            {
                thirdNumber *= 10;
                times++;
            }

            ulong denominator = Convert.ToUInt64(Math.Pow(10, times));
            ulong numerator = Convert.ToUInt64(thirdNumber);
            ulong i = 2;

            while (numerator >= i && denominator >= i)
            {
                Console.WriteLine(numerator % i);
                Console.WriteLine(denominator % i);
                if (numerator % i == 0 && denominator % i == 0)
                {
                    numerator /= i;
                    denominator /= i;
                }
                else
                {
                    i++;
                }
            }

//            Console.WriteLine(GCD(numerator, denominator));

//            Console.WriteLine(secondNumber);
            return $"{secondNumber * denominator + numerator} / {denominator}";
        }

        private static uint GreatestCommonDivisor(uint valA, uint valB)
        {
            // return 0 if both values are 0 (no GSD)
            if (valA == 0 &&
                valB == 0)
            {
                return 0;
            }
            // return value b if only a == 0
            else if (valA == 0 &&
                     valB != 0)
            {
                return valB;
            }
            // return value a if only b == 0
            else if (valA != 0 && valB == 0)
            {
                return valA;
            }
            // actually find the GSD
            else
            {
                uint first = valA;
                uint second = valB;

                while (first != second)
                {
                    if (first > second)
                    {
                        first = first - second;
                    }
                    else
                    {
                        second = second - first;
                    }
                }

                return first;
            }
        }


        public static string ConvertMy(decimal value)
        {
            // get the whole value of the fraction
            decimal mWhole = Math.Truncate(value);

            // get the fractional value
            decimal mFraction = value - mWhole;

            // initialize a numerator and denomintar
            uint mNumerator = 0;
            uint mDenomenator = 1;

            // ensure that there is actual a fraction
            if (mFraction > 0m)
            {
                // convert the value to a string so that you can count the number of decimal places there are
                string strFraction = mFraction.ToString().Remove(0, 2);

                // store teh number of decimal places
                uint intFractLength = (uint)strFraction.Length;

                // set the numerator to have the proper amount of zeros
                mNumerator = (uint)Math.Pow(10, intFractLength);

                // parse the fraction value to an integer that equals [fraction value] * 10^[number of decimal places]
                uint.TryParse(strFraction, out mDenomenator);

                // get the greatest common divisor for both numbers
                uint gcd = GreatestCommonDivisor(mDenomenator, mNumerator);

                // divide the numerator and the denominator by the gratest common divisor
                mNumerator = mNumerator / gcd;
                mDenomenator = mDenomenator / gcd;
            }

            // create a string builder
            StringBuilder mBuilder = new StringBuilder();

            // add the whole number if it's greater than 0
            if (mWhole > 0m)
            {
                mBuilder.Append(mWhole);
            }

            // add the fraction if it's greater than 0m
            if (mFraction > 0m)
            {
                if (mBuilder.Length > 0)
                {
                    mBuilder.Append(" ");
                }

                mBuilder.Append(mDenomenator);
                mBuilder.Append("/");
                mBuilder.Append(mNumerator);
            }

            return mBuilder.ToString();
        }



    }

}