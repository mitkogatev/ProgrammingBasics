using System;


namespace _19.PoolPipesHomeWork
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var filled = (p1 * h) + (p2 * h);
            if (filled<=v)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",Math.Truncate(filled/v*100),Math.Truncate(p1*h/filled*100), Math.Truncate(p2 * h / filled * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1:f1} liters.",h,filled-v );

            }
        }
    }
}
