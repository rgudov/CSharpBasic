using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14ModifyBitGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Position:");
            int p = int.Parse(Console.ReadLine());
              
            int mask = ~(1 << p);      
            int result = n & mask;     
            Console.WriteLine(result); 

  
        }
    }
}
