//Calculati suma si produsul numerelor de la 1 la n. 

namespace nSumProd;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n : ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int prod = 0;

        if (n > 0) prod++;
        for (int i = 1; i <= n; ++i)
        {
            sum += i;
            prod *= i;
        }

        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Product = {prod}");
    }
}