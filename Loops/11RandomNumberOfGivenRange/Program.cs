using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberOfGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("min =");
            int min = int.Parse(Console.ReadLine());
            Console.Write("max =");
            int max = int.Parse(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", random.Next(min, max + 1));
            }
        }
    }
}
