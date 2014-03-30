using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12RandomNumberToN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int length = int.Parse(Console.ReadLine());
           

            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", random.Next(0, length + 1));
            }
        }
    }
}
