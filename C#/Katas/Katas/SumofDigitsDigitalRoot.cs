using System;
using System.Linq;

namespace Katas
{
    public class SumofDigitsDigitalRoot
    {
        public long DigitalRoot(long n)
        {
            return (n > 9)
                ? DigitalRoot(n.ToString().ToCharArray().Sum(s => Convert.ToInt32(s.ToString())))
                :n.ToString().ToCharArray().Sum(s => Convert.ToInt32(s.ToString()));
        }
    }
}