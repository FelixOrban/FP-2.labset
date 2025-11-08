//Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 

namespace nNegZerPoz;

using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type in any numbers with spaces between them(ex: 1 2 3...) : ");
        string input = Console.ReadLine() ?? string.Empty;
        int countNeg = 0;
        int countZer = 0;
        int countPoz = 0;

        foreach (var numString in input.Split(' ' , StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int numInt))
            {
                if(numInt<0)
                    countNeg++;
                else if(numInt>0)
                    countPoz++;
                else
                    countZer++;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid number");
        }    
        Console.WriteLine($"Negative numbers: {countNeg}");
        Console.WriteLine($"Zero numbers: {countZer}");
        Console.WriteLine($"Positive numbers: {countPoz}");
    }
}