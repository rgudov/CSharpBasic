using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01exchangeGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double c;

            if (a > b)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("{0} {1}", a, b);

            }
            else
            {
                Console.WriteLine("{0} {1}", a, b);
            }



        }
    }
}
