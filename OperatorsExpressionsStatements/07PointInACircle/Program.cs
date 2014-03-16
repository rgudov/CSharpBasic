using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 points");
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("y: ");
            double y = double.Parse(Console.ReadLine());
            double sum = (x*x) + (y*y);
            if (sum <= 2)
            {
                Console.WriteLine("Points are inside the circle");
            }
            else
            {
                Console.WriteLine("Points intersect the circle");
            }

        }
    }
}
