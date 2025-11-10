// O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 

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
        int turned = 0; // only one turn allowed, bitonic sequence has only one apex
        int? first = null;
        int? last = null;

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int num))
            {
                if(first == null)
                    first = num;

                if (prev != null && prev < num)
                {
                    if (decreasing)
                        turned++; //from decreasing starts to increase

                    increasing = true;
                    decreasing = false;
                }

                if (prev != null && prev > num)
                {
                    if(increasing)
                        turned++; // from increasing starts to decrease

                    decreasing = true;
                    increasing = false;
                }

                prev = num;
                last = num;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid integer.");
        }
        Console.WriteLine();

        if(first > last && increasing)
            turned++;

        if (first < last && decreasing)
            turned++;
        //with rotation, it will be a simple bitonic sequence

        if (turned == 1)
            Console.WriteLine("The sequence IS a rotation bitonic sequence.");
        else
            Console.WriteLine("The sequence is NOT a rotation bitonic sequence.");
    }
}