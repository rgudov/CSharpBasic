using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06TheBiggersOf5Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("d=");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("e=");
            double e = double.Parse(Console.ReadLine());


            Console.WriteLine("The biggers is:");
            if (a >= b && a >= c && a >= d && a>= e)
            {
                Console.WriteLine(a);
            }
            else if (b >= a && b >= c && b >= d && b >= e)
            {
                Console.WriteLine(b);
            }
            else if (c >= a && c >= b && c >= d && c>= e)
            {
                Console.WriteLine(c);
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                Console.WriteLine(d);
            }
            else if (e >= a && e >= b && e >= c && e >= d)
            {
                Console.WriteLine(e);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
