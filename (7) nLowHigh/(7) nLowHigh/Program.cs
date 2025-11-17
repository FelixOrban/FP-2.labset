//Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 

namespace nLowHigh;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type in any numbers between spaces (ex : 1 2 3 ... ) : ");
        string input = Console.ReadLine() ?? string.Empty;

        int? lowest = null;
        int? highest = null;

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int num))
            {
                if (lowest == null)
                {
                    lowest = num;
                    highest = num;
                }

                if (lowest > num)
                    lowest = num;

                if (highest < num)
                    highest = num;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid");
        }
        Console.WriteLine($"Lowest number: {lowest}");
        Console.WriteLine($"Highest number: {highest}");
    }
}