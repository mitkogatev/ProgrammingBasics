using System;

namespace _12.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentFibonacciNumber = 0;
            int f1 = 1, f2 = 1;
            int count = 2;
            if (n < 2) { Console.WriteLine(1);return; } 
            while (count<=n)
            {
                currentFibonacciNumber = f1 + f2; 
                f1 = f2; 
                f2 = currentFibonacciNumber;
                count++;
            }
            Console.WriteLine(currentFibonacciNumber); 
        }
    }
}
