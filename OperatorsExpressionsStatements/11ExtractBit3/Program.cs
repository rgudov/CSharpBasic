using System;

class FindBit3
{
    static void Main()
    {
        string number = null;
        Console.Write("Enter number: ");
        number = Console.ReadLine();
        int intNumber = int.Parse(number);
        int mask = 1 << 3;
        int result = intNumber & mask;
        result >>= 3;
        Console.WriteLine("The bit 3 of a the number {0}[{1}] is {2}",
            intNumber, Convert.ToString(intNumber, 2).PadLeft(32, '0'), result);
    }
}