using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("length of loop");
            int length = int.Parse(Console.ReadLine());

            int min = int.MaxValue;
            int max = int.MinValue;
            double sum = 0;
            double avg = 0;


            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                min = Math.Min(min, number);
                max = Math.Max(max, number);
                sum += number;
                avg = sum / number;

            }
            Console.WriteLine("min: " + min);
            Console.WriteLine("max: " + max);
            Console.WriteLine("sum: " + sum);
            Console.WriteLine("avg: {0:F2}",avg);
        }
    }
}
