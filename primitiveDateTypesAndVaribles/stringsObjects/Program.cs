using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firststr = "Hello";
            string secondstr = "World";
            object both = firststr + " " + secondstr;
            string sentence = (string)both;
            Console.WriteLine(sentence);
        }
    }
}
