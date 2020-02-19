
namespace Katas
{
    public class kyu6IPValidation
    {
        public static bool is_valid_IP(string ipAddres)
        {
            if(ipAddres.Contains(' ')) return false;
            var splited = ipAddres.Split('.');
            if (splited.Length != 4) return false;
            foreach (var one in splited)
            {
                if(one.Length > 1 && one[0].Equals('0')) return false;
                var n = 0;
                if (!(int.TryParse(one, out n) && n >= 0 && n <= 255))
                {
                    return false;
                }
            }
            return true;
        }
    }
}