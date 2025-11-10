namespace BitonicORInvBitonic;
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
        bool turned = false; // only one turn allowed, bitonic sequence has only one apex

        foreach (var numString in input.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            if (int.TryParse(numString, out int num))
            {
                if (prev != null && prev < num)
                {
                    if (decreasing && turned) // that means it started to increase for the second time
                    {
                        Console.WriteLine("The sequence is NOT a bitonic sequence.");
                        return;
                    }

                    if (decreasing && !turned) // from decreasing starts to increase
                        turned = true;

                    increasing = true;
                    decreasing = false;
                }

                if (prev != null && prev > num)
                {
                    if (increasing && turned) // that means it started to decrease for the second time
                    {
                        Console.WriteLine("The sequence is NOT a bitonic sequence.");
                        return;
                    }

                    if (increasing && !turned)
                        turned = true; //from increasing starts to decrease

                    decreasing = true;
                    increasing = false;
                }
                prev = num;
            }
            else
                Console.WriteLine($"'{numString}' is not a valid integer.");
        }
        Console.WriteLine();

        if (turned)
            Console.WriteLine("The sequence IS a bitonic sequence.");
        else
            Console.WriteLine("The sequence is NOT a bitonic sequence.");
    }
}