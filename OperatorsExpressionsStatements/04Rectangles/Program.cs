using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width of trigle:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height of trigle:");
            double height = double.Parse(Console.ReadLine());

            double perimeter = (width + height) * 2;
            double area = (width * height);
            Console.WriteLine("Perimeter: {0}  |   Area: {1}", perimeter, area);
        }
    }
}
