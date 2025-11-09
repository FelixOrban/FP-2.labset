//Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...

namespace nFibonacci;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("n : ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("'n' has to be greater than 0");
            return;
        }

        long fibN = Fibonacci(n);
        Console.WriteLine($"the {n}. number in the fibonacci line is : {fibN}");
    }
    static long Fibonacci(int n)
    {
        if (n == 1) return 0;
        if (n == 2) return 1;

        long prev = 0;
        long curr = 1;

        for (int i = 3; i <= n; i++)
        {
            long next = prev + curr; //Fi = F(i-1) + F(i-2)
            prev = curr; 
            curr = next;
        }
        return curr;
    }

}