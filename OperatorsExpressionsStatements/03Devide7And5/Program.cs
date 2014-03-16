using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Devide7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if ((num % 5) == 0 && (num % 7) == 0)
            {
                Console.WriteLine("The number can be divided by 7 and 5");
            }
            else
            {
                Console.WriteLine("The number can`t be divided by 7 and 5");
            }
        }
    }
}
