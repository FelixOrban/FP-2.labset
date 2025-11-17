//Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.
namespace BinaryFogSign;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("0 -> (           1 -> ) \n");
        Console.Write("Type 0 or 1 numbers between spaces(ex : 0 1 1 0 0 1 0 ... ) : ");
        string input = Console.ReadLine() ?? string.Empty;
        Console.WriteLine();

        int count = 0; // counting the '(' , if its -1, than it not corect.
        int max = 0;

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int num))
            {
                if (num == 0)
                    count++;
                else if (num == 1)
                    count--;
                else
                    Console.WriteLine($"'{num}' is not 0 or 1.");

                if (count < 0)
                {
                    Console.WriteLine("The sequence is not correct.");
                    return;
                }

                if (count > max)
                    max = count;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid integer.");
        }

        if (count == 0)
            Console.WriteLine($"\nThe sequence is correct, the max number was {max}.");
        else
            Console.WriteLine("\nThe sequence is not correct.");
    }
}