using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your loop length: ");
            int length = int.Parse(Console.ReadLine());


            double result = 0;

            for (double i = 0; i < length; i++)
            {
                Console.Write("Number {0}: ", i);
                double number = double.Parse(Console.ReadLine());

                result += number;
            }

            Console.WriteLine("Sum of these numbers is {0} ", result);
        }
    }
}
