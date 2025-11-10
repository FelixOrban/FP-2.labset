//Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 

namespace EqualStreak;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type any numbers between spaces(ex : 1 2 3 ...) : ");
        string input = Console.ReadLine() ?? string.Empty;

        int count = 1;
        int max = 0;
        int? prev = null;

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int num))
            {
                if(prev != null && prev == num)
                    count++;
                else
                    count = 1;

                if (count > max)
                    max = count;

                prev = num;

            }
            else
                Console.WriteLine($"'{numString}' is not a valid number");
        }
        Console.WriteLine($"The maximum number of consecutive equal numbers is: {max}");
    }
}
