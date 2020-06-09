using System;

namespace Katas
{
    public class kyu6ValidateMyPassword
    {
        public static void Main(string[] args)
        {

        }

        public static string validator(string password)
        {
            Console.WriteLine(password);
            if(password.Length <= 3 || password.Length > 20) return "INVALID";
            var numbers = false;
            var letters = false;
            foreach (var one in password)
            {
                if (char.IsDigit(one)) numbers = true;
                if (char.IsLetter(one)) letters = true;
                if (!char.IsDigit(one) && !char.IsLetter(one)) return "INVALID";
            }

            return (numbers && letters) ? "VALID": "INVALID";
        }


    }
}