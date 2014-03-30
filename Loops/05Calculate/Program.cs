using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (1 < k && k < n && n < 100)
            {
                ulong resuult = 1;
                for (int index = k + 1; index <= n; index++)
                {
                    resuult *= (ulong) index;
                }
                Console.WriteLine(resuult);
            }
            else
            {
                Console.WriteLine("out of range");
            }
        }
    }
}

//Calculate 1 + 1!/X + 2!/X2 + … + N!/XN