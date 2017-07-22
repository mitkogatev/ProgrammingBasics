using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PoolPipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            var filled = h * p1 + h * p2;
            if (filled<=v)
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",Math.Truncate(filled/v*100), Math.Truncate(h * p1/filled*100), Math.Truncate(h * p2/filled*100));
            else
                Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters.",h,filled-(double)v);
        }
    }
}
