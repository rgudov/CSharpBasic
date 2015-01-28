using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ZeroSubset
{
    class Program
    {
        static void Main(string[] args)
        {
            string ConsoleString = Console.ReadLine();
            string[] numbersLikeString = ConsoleString.Split(' ');
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(numbersLikeString[i]);
            }

            if (numbers.Sum() == 0)
            {
                Console.WriteLine("0 + 0 + 0 + 0 + 0 = 0");
                return;
            }

            long sum = 0;
            string result = "";
            bool isZeroSubset = false;


            for (int combination = 1; combination < 32; combination++)
            {
                int[] bits = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    bits[i] = (combination >> i) & 1;
                    sum += numbers[i] * bits[i];
                    if (bits[i] == 1)
                    {
                        result += numbers[i] + " + ";
                    }
                }

                result = result.Trim('+', ' ');
                result += " = " + sum;

                if (sum == 0)
                {
                    Console.WriteLine(result);
                    isZeroSubset = true;
                }

                result = "";
                sum = 0;
            }

            if (isZeroSubset == false)
            {
                Console.WriteLine("no zero subset");
            }
        }
    }
}
