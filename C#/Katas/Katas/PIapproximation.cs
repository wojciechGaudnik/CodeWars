using System;
using System.Collections;

namespace Katas
{
    public class PIapproximation
    {
        public static ArrayList iterPi(double epsilon)
        {
            ArrayList answer = new ArrayList();
            double pi = 1;
            int iterations = 0;
            while (true)
            {
                int denominator = iterations * 2 + 3;
                pi += (iterations++ % 2 == 0)?-(1.0/denominator):(1.0/denominator);
                if(Math.Abs(Math.PI - pi * 4) <= epsilon)
                {
                    answer.Add(iterations + 1);
                    answer.Add(Math.Round(pi*4, 10));
                    return answer;
                }
            }
        }
    }
}