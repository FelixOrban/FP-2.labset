//Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 

namespace MonGroups;
using System;

class Program
    {
    static void Main(string[] args)
    {
        Console.Write("Type any numbers between spaces(ex : 1 2 3 ...) : ");
        string input = Console.ReadLine() ?? string.Empty;

        int count = 0;
        bool group = false;

        foreach(var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if(int.TryParse(numString, out int num))
            {
                if (num != 0)
                {
                    if (!group)
                    {
                        count++;
                        group = true;
                    }
                }
                else
                    group = false;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid integer.");
        }
        Console.WriteLine();
        Console.WriteLine($"The number of groups of non-zero numbers is: {count}");

    }
}