using System;

namespace Katas
{
    public static class IsTheStringUppercase
    {
        public static bool IsUpperCase(this string text)
        {
            foreach (char w in text.ToCharArray())
            {
                if (Char.IsLower(w)) return false;
            }
            return true;
        }
    }
}