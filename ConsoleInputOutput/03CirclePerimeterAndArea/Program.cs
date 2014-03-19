using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CirclePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Circle r is? : ");
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double perimeter = pi * 2 * r;
            double area = pi * r * r;

            Console.WriteLine("The circle perimeter is: {0:F2}", perimeter);
            Console.WriteLine("The circle area is: {0:F2}", area);

        }
    }
}
