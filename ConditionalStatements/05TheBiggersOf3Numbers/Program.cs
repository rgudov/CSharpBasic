using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05TheBiggersOf3Numbers
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
            Console.WriteLine("The biggers is:");
            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine(b);
            }
            else if (c >= a && c >= b)
            {
                Console.WriteLine(c);
            }
            

        }
    }
}
