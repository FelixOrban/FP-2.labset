//Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 

namespace SumInvers;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type any numbers between spaces(ex : 1 2 3 ...) : ");
        string input = Console.ReadLine() ?? string.Empty;

        double sum = 0;

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int num) && num != 0)
            {
                double inverse = 1.0 / num;
                sum += inverse;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid number.");
        }
        Console.WriteLine($"The sum of inverses is: {sum}");
    }
}