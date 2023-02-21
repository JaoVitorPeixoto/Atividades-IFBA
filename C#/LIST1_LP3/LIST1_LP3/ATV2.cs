using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST1_LP3
{
    class ATV2
    {
        static public void Main(string[] args)
        {

            int a, b, c;
            double delta, x1, x2;

            a = 2;
            b = -3;
            c = 1;

            delta = b * b - 4 * a * c;

            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("A = {0}, B = {1}, C = {2}\nDelta = {3}\nX1 = {4}, X2 = {5}", a, b, c, delta, x1, x2);  

        }
    }
}