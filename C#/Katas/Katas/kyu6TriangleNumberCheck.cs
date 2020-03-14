
namespace Katas
{
    public class kyu6TriangleNumberCheck
    {
        public static bool isTriangleNumber(long number)
        {
            if(number == 0 || number == 1) return true;
            var sum = 1;
            var add = 2;
            while (sum < number)
            {
                sum += add++;
                if (sum == number) return true;
            }
            return false;
        }

    }
}