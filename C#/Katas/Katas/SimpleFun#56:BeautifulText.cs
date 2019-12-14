namespace Katas
{
    public class SimpleFun_56_BeautifulText
    {
       public bool BeautifulText(string s, int l, int r)
        {
            for (var i = l; i <= r; i++)
            {
                var temp = i;
                while (temp < s.Length && s[temp] == ' ')
                {
                    temp += i + 1;
                    if(temp == s.Length) return true;
                }
            }
            return false;
        }
    }
}