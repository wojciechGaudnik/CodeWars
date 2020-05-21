using System;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Katas
{
    public class kyu6AddingBinaryNumbers
    {
        public static void Main(string[] args)
        {
            var first = "111";
            var second = "10";
            Console.WriteLine(Convert.ToInt64(first, 2));
            Console.WriteLine(Convert.ToString(7, 2));
            // Console.WriteLine(test);
            Console.WriteLine(Add("1101","10111"));
        }

        public static string Add(string a, string b)
        {
            Console.WriteLine(a + " <---> " + b);
            var maxLength = (a.Length > b.Length) ? a.Length : b.Length;
            a = new String(new String('0', maxLength - a.Length) + a);
            b = new String(new String('0', maxLength - b.Length) + b);
            var reminder = '0';
            var answer = new StringBuilder();
            for (var i = a.Length - 1; i >= 0; i--)
            {
                if (reminder == '0')
                {
                    if (a[i] == '0' && b[i] == '0')
                    {
                        answer.Insert(0, '0');
                        continue;
                    }

                    if (a[i] == '1' && b[i] == '1')
                    {
                        answer.Insert(0, '0');
                        reminder = '1';
                        continue;
                    }

                    if (a[i] == '1' || b[i] == '1')
                    {
                        answer.Insert(0, '1');
                    }
                }
                else
                {
                    if (a[i] == '0' && b[i] == '0')
                    {
                        answer.Insert(0, '1');
                        reminder = '0';
                        continue;
                    }

                    if (a[i] == '1' && b[i] == '1')
                    {
                        answer.Insert(0, '1');
                        reminder = '1';
                        continue;
                    }

                    if (a[i] == '1' || b[i] == '1')
                    {
                        answer.Insert(0, '0');
                    }
                }
            }
            if(reminder == '1') answer.Insert(0, '1');
            var ready = answer.ToString().TrimStart('0');
            return (ready.Length == 0) ? "0" : ready;
        }


    }
}