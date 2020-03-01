using System.Linq;

namespace Katas
{
    public class kyu6ValidateCreditCardNumber
    {
        public bool validate(string n)
        {
            return n
               .Reverse()
               .Where(c => c != ' ')
               .Select((c, i) => (i % 2 == 1) ? (c - '0') * 2 : (c - '0'))
               .Select(m => (m > 9)? m.ToString()[0] -'0' + m.ToString()[1] -'0':m)
               .Sum() % 10 == 0;
        }
    }
}