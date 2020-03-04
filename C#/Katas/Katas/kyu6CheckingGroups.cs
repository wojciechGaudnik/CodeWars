namespace Katas
{
    public class kyu6CheckingGroups
    {

        public static bool Check(string input)
        {
            while (input.Length > 0)
            {
                var startLength = input.Length;
                input = input.Replace("()", "").Replace("[]", "").Replace("{}", "");
                if(input.Length == startLength) return false;
            }
            return true;
        }

        public static bool Check2(string input)
        {
            var count = 0;
            foreach (var one in input)
            {
                switch (one)
                {
                    case '(':
                        count += 1;
                        break;
                    case '[':
                        count += 2;
                        break;
                    case '{':
                        count += 3;
                        break;
                    case ')':
                        count -= 1;
                        break;
                    case ']':
                        count -= 2;
                        break;
                    case '}':
                        count -= 3;
                        break;
                }
                if (count < 0) return false;
            }
            return count == 0;
        }
    }
}