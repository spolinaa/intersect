using System;

namespace geometry
{
    public class Calculator
    {
        private static double sqr(int x)
        {
            return Math.Pow(x, 2);
        }

        public static bool intersection(int x0, int y0, int r, int x1, int y1, int x2, int y2)
        {
            if ((x1 == x2) && (y1 == y2))
            {
                throw new System.ArgumentException("Points must be different"); //надо ловить при выводе в гуи
            }
            double a = sqr(x2 - x1) + sqr(y2 - y1);
            double b = 2 * ((x2 - x1) * (x1 - x0) + (y2 - y1) * (y1 - y0));
            double c = sqr(x1 - x0) + sqr(y1 - y0) - sqr(r);
            double D = Math.Pow(b, 2.0) - 4 * a * c;
            if (D < 0) { return false; }
            double t1 = (-b + Math.Sqrt(D)) / (2 * a);
            double t2 = (-b - Math.Sqrt(D)) / (2 * a);
            if (((t1 < 0) || (t1 > 1)) && ((t2 < 0) || (t2 > 1)))  { return false; }
            return true;
        }
    }

}
