using System;
using System.Text.RegularExpressions;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Program();
            Console.WriteLine(test.solution(1041));
            // Console.WriteLine(test.solution(32));
        }

        public int solution(int N)
        {
            var binary = Convert.ToString(N, 2).Trim('0').Split('1');
            var max = 0;
            foreach (var one in binary)
            {
                if(one.Length > max) max = one.Length;
            }
            return max;
        }
    }
}