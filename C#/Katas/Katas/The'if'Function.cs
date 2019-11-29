using System;

namespace Katas
{
    public class The_if_Function
    {
        public static void If(bool condition, Action func1, Action func2)
        {
            (condition ? func1 : func2)();
        }

    }
}