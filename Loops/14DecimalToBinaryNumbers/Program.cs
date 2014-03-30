using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long decNumber = long.Parse(Console.ReadLine());
            string binNumber = "";
            while (decNumber != 0)
            {
                int remain = (int)decNumber % 2;
                decNumber /= 2;
                binNumber = remain + binNumber;
            }
            Console.WriteLine(binNumber);
        }
    }
}
