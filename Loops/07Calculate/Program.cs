using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (1 < k && k < n && n < 100)
            {
                int result1 = 1;
                int result2 = 1;
                int result;
                int count = 1;
                for (int index = n - k + 1; index <= n; index++)
                {
                    result1 *= index;
                    if (count <= k)
                    {
                        result2 *= count;
                        count++;
                    }
                }
                result = result1 / result2;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("out of range");
            }
        }
    }
}
