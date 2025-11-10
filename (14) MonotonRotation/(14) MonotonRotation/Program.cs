//O<secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita.

namespace MonotonRotation;
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
        int breaksInc = 0;
        int breaksDec = 0;

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int num))
            {
                if (first == null)
                    first = num;

                if (prev != null && prev > num)
                    breaksInc++;

                if(prev != null && prev < num)
                     breaksDec++;

                prev = num;
                last = num;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid integer.");
        }
        Console.WriteLine();

        if (last > first)
            breaksInc++;
        if( last < first)
            breaksDec++;

        if (breaksInc < 2 || breaksDec < 2)
            Console.WriteLine("The sequence IS a rotated monoton sequence.");
        else
            Console.WriteLine("The sequence is NOT a rotated monoton sequence.");
    }
}