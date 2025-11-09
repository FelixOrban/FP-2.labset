//Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1.

namespace nPosition;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type in any numbers with spaces between them(ex: 1 2 3...) : ");
        string input = Console.ReadLine() ?? string.Empty;
        Console.Write("Type in the number you want to find : ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int position = 0;
        bool found = false;

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int numInt))
            {
                if (numInt == a)
                {
                    Console.WriteLine($"The first number '{a}' is on the position '{position}'");
                    found = true;
                    break;
                }
                position++;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid number");
        }

        if (!found)
            Console.WriteLine("-1");

    }
}