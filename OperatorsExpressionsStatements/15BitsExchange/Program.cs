using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15BitsExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = uint.Parse(Console.ReadLine());
            long mask = 7;
            long thirdFourthFifthBits = ((mask << 3) & number) >> 3; //1)  take the 3rd, 4th and 5th bits and save them
            long otherBits = ((mask << 24) & number) >> 24;          //2)  take the 24th, 25th and 26th bits and save them
            number = ~(mask << 24) & number;                         //3)  make the 24th, 25th, 26th bits equal to 0
            number = ~(mask << 3) & number;                          //4)  make the 3rd, 4th, 5th bits equal to 0
            number = (thirdFourthFifthBits << 24) | number;          //5)  fill the 24th, 25th, 26th with the new values
            number = (otherBits << 3) | number;                      //6)  fill the 3rd, 4th, 5th with the new values
            Console.WriteLine(number);
            

        }
    }
}

