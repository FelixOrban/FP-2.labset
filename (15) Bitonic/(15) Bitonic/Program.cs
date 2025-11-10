//O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 

namespace Bitonic;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type any numbers between spaces(ex : 1 2 3 ... ) : ");
        string input = Console.ReadLine() ?? string.Empty;

        int? prev = null;
        bool increasing = false;
        bool decreasing = false;
        bool turned = false; // only one turn allowed, bitonic sequence has only one apex

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int num))
            {
                if (prev != null && prev < num)
                {
                    if (decreasing) // that means it started to increase for the second time OR started increasing after decreasing
                    {
                        Console.WriteLine("The sequence is NOT a bitonic sequence.");
                        return;
                    }
                    increasing = true;
                }

                if (prev != null && prev > num)
                {
                    if (increasing)
                        turned = true; //from increasing starts to decrease

                    decreasing = true;
                }

                prev = num;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid integer.");
        }
        Console.WriteLine();

        if (turned && decreasing && increasing)
            Console.WriteLine("The sequence IS a bitonic sequence.");
        else
            Console.WriteLine("The sequence is NOT a bitonic sequence.");
    }
}