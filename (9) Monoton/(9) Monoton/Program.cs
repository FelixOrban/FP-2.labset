//Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 

namespace Monoton;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type any numbers between spaces(ex : 1 2 3 ...) : ");
        string input = Console.ReadLine() ?? string.Empty;

        bool increasing = true;
        bool decreasing = true;
        int? prev = null;

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int num))
            {
                if (prev != null)
                {
                    if (num > prev)
                        decreasing = false;

                    if (num < prev)
                        increasing = false;
                }
                prev = num;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid number");
        }

        if (increasing || decreasing)
            Console.WriteLine("the numbers are monoton");
        else
            Console.WriteLine("the numbers are NOT monoton");
    }
}
