//Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.

namespace NumbersIncrease;
using System;
using System.Linq;

class Program
    {
    static void Main(string[] args)
    {
        Console.Write("Type in any numbers with spaces between them(ex: 1 2 3...) : ");
        string input = Console.ReadLine() ?? string.Empty;

        int? previous = null;

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int numInt))
            {
                if (previous != null && numInt < previous)
                {
                    Console.WriteLine("The numbers are NOT in increasing order.");
                    return;
                }
                previous = numInt;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid number");
        }
        Console.WriteLine();
        Console.WriteLine("The numbers are in increasing order.");
    }
}