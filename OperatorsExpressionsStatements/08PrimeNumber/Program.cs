using System;

class CheckIfPrime
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        sbyte number = sbyte.Parse(Console.ReadLine());
        bool isPrime = ((number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0) && (number != 1));
        bool primeCases = ((number == 2) || (number == 3) || (number == 5) || (number == 7));
        Console.WriteLine((isPrime || primeCases) ? "{0} is prime." : "{0} is not prime.", number);
    }
}