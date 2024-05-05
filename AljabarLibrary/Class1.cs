namespace AljabarLibrary
{
    public class Class1
    {
        public static double[] AkarPersamaanKuadrat(double a, double b,double c)
        {
          
          double  persamaan = Math.Pow(b, 2) - 4 * a * c;

            if (persamaan >= 0)
            {
                double root1 = (-b + Math.Sqrt(persamaan)) / (2 * a);
                double root2 = (-b - Math.Sqrt(persamaan)) / (2 * a);
                return new double[] { root1, root2 };
            }
            else
            {
                return new double[] { };
            }
        }
        public static double[] HasilKuadrat(double a, double b)
        {
            double aKuadrat = Math.Pow(a, 2);
            double duaAB = 2 * a * b;
            double bKuadrat = Math.Pow(b, 2);
            return new double[] {aKuadrat, duaAB, bKuadrat };
        }
    }
}

