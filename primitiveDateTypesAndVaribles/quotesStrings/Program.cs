using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quotesStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string quotes1 = "The \"use\" of quotations causes difficulties.";
            string quotes2 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(quotes1 + "\n" + quotes2);
        }
    }
}
