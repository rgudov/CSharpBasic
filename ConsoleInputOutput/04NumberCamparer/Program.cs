using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04NumberCamparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            double b = double.Parse(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine("{0} is greater", a);
            }
            else
            {
                Console.WriteLine("{0} is greater",b);
            }
        }
    }
}
