using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers: ");
            Console.WriteLine("Number one: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Number two:");
            double num2 = double.Parse(Console.ReadLine());
            bool eps = (num1 == num2);
            Console.WriteLine(" Numbers are equal: {0}", eps);
        }
    }
}
