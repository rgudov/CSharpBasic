using System;
using System.Collections.Generic;
using System.Text;

namespace PrintASCII
{
    class PrintASCII
    {

        static void Main(string[] args)
        {
           
            for (int i = 0; i <= 255; i++)
            {
                System.Console.WriteLine("{0} = {1}", i, (char)i);
            }
        }
    }

}