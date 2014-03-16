using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side a:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter side b:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter h of trapezoid: ");
            float h = float.Parse(Console.ReadLine());

            float area = ((a + b) * h) / 2;
            Console.WriteLine("The area is: {0}", area);
        }
    }
}
