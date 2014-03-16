using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ThirdDigitIs7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (((num / 100) % 10) == 7)
            {
                Console.WriteLine("Third Digit is 7");
            }
            else
            {
                Console.WriteLine("Third Digit isn`t 7");
            }
        }
    }
}
