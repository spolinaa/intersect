using System;

namespace geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x0 = rand.Next(-10, 10);
            int y0 = rand.Next(-10, 10);
            int r  = rand.Next(10);
            int x1 = rand.Next(-10, 10);
            int y1 = rand.Next(-10, 10);
            int x2 = rand.Next(-10, 10);
            int y2 = rand.Next(-10, 10);
            bool res = Calculator.intersection(x0, y0, r, x1, y1, x2, y2);
        }
    }
}
