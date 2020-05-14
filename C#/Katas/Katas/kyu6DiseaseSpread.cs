namespace Katas
{
    public class kyu6DiseaseSpread
    {
        public static int Epidemic(int tm, int n, int s0, int i0, double b, double a)
        {
            var dt = (double) tm / n;
            double sk = s0;
            double ik = i0;
            double rk = 0;
            var maxInfected = ik;
            while (n > 0)
            {
                var sk1 = sk - dt * b * sk * ik;
                var ik1 = ik + dt * (b * sk * ik - a * ik);
                var rk1 = rk + dt * ik * a;
                if (maxInfected < ik1) maxInfected = ik1;
                (sk, ik, rk) = (sk1, ik1,  rk1);
                n--;
            }
            return (int) maxInfected;
        }
    }
}