using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11NumbersIntervalDividableGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first positive integer number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second positive integer number:");
            int secondNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int i = 0;
            Console.WriteLine("****");
            for (i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {

                    Console.WriteLine(i);
                    counter++;

                }
            }
            Console.WriteLine("****");
            Console.WriteLine("Number of integer is: {0}", counter);

        }
    }
}
