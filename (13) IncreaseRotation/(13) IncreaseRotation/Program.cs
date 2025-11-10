//O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 

namespace IncreaseRotation;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type any numbers between spaces(ex : 1 2 3 ... ) : ");
        string input = Console.ReadLine() ?? string.Empty;

        int? prev = null;
        int? first = null;
        int? last = null;
        int breaks = 0; // if is higher than 2 than is not rotated increasing

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int num))
            {
                if (first == null)
                    first = num;

                if (prev != null && prev > num)
                    breaks++;

                prev = num;
                last = num;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid integer.");
        }
        Console.WriteLine();

        if (last > first)// rotation connection
            breaks++;

        if (breaks < 2)
            Console.WriteLine("The sequence IS a rotated increasing sequence.");
        else
            Console.WriteLine("The sequence is NOT a rotated increasing sequence.");
    }
}