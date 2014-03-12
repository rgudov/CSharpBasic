using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            byte varribleA = 5;
            byte varribleB = 10;
            Console.WriteLine("VarribleA = {0} and VarribleB = {1}", varribleA, varribleB);
            byte varribleC = varribleB;
            varribleB = varribleA;
            varribleA = varribleC;
            Console.WriteLine("VarribleA = {0} and VarribleB = {1}", varribleA, varribleB);

        }
    }
}
