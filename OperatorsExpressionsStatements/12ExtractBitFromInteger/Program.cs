using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12ExtractBitFromInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Position:");
            int p = int.Parse(Console.ReadLine());
            int bit = (number >> p) & 1;
            Console.WriteLine(bit);   

        }
    }
}



