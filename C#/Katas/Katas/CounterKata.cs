using System;

namespace Katas
{
    public class Counter
    {

        // public static void Main(string[] args)
        // {
        //     Counter test = new Counter();
        //     test.Increase();
        //     Console.WriteLine(test.Value);
        // }

        private int _Value;
        public int Value
        {
            get => _Value;
            private set => _Value = value;
        }

        public Counter()
        {
            Value = 0;
        }

        public void Increase()
        {
            Value++;
        }

        public void Reset()
        {
            Value = 0;
        }
    }
}