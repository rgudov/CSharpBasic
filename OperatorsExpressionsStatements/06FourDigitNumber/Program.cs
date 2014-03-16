using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 4 digit number:");
            int num = int.Parse(Console.ReadLine());
            int num1 = num % 10;
            int num2 = (num / 10) % 10;
            int num3 = (num / 100) % 10;
            int num4 = (num / 1000) % 10;
            int sum = num1 + num2 + num3 + num4;
            Console.WriteLine("Sum of 4 digits is: {0}", sum);
            Console.WriteLine("Revers the digits: {0}{1}{2}{3}", num1, num2, num3, num4);
            Console.WriteLine("Last digit in firs position: {0}{1}{2}{3}", num1, num3, num2, num4);
            Console.WriteLine("Exchanges the second and the third digits: {0}{1}{2}{3}", num4, num2, num3, num1);
        }
    }
}
