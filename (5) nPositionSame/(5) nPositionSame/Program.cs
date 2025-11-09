//Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 

namespace nPositionSame;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type in any numbers with spaces between them(ex: 1 2 3...) : ");
        string input = Console.ReadLine() ?? string.Empty;
        Console.WriteLine();

        int position = 0;
        int count = 0;

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int numInt))
            {
                if (numInt == position)
                    count++;
                position++;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid number");
        }
        Console.WriteLine($"There are '{count}' numbers equal to their position.");

    }
}