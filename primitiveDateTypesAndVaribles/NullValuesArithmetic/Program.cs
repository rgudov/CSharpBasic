using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? nullableInteger = null;
            double? floatNumber = null;
            Console.WriteLine("Null value: " + nullableInteger);
            Console.WriteLine("Null value: " + floatNumber);

            nullableInteger += 7;
            floatNumber += 4.5;
            Console.WriteLine("Number + null value: " + nullableInteger);
            Console.WriteLine("Number + null value: " + floatNumber);

            nullableInteger = 7;
            floatNumber = 4.5;
            Console.WriteLine("Number value: " + nullableInteger);
            Console.WriteLine("Number value: " + floatNumber);
        }
    }
}
