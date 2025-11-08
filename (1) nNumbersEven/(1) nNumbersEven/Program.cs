//Se da o secventa de n numere. Sa se determine cate din ele sunt pare.

namespace nNumbersEven;

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type any numbers between spaces(ex: 1 2 3...) : ");
        string input = Console.ReadLine() ?? string.Empty;
        int count = 0;

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int numInt))
            {
                if (numInt % 2 == 0)
                    count++;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid number.");
        }
        Console.WriteLine($"There is {count} even numbers");
    }
}