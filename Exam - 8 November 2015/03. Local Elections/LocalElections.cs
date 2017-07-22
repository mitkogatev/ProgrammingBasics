using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Local_Elections
{
    class LocalElections
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int vote = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine().ToLower();

            string eLine = new string('.', 13);

            //drawEmpty(1);
            //drawV();
            //drawX();
            Console.WriteLine(eLine);
            for (int i = 1; i <= n; i++)
            {
                if (i == vote) if (sign == "x") drawX(i); else drawV(i);
                else
                    drawEmpty(i);
                Console.WriteLine(eLine);

            }


        }

        private static void drawX(int num)
        {
            Console.WriteLine("...+-----+...");
            Console.WriteLine("...|.\\./.|...");
            Console.WriteLine("{0:d2}.|..X..|...",num);
            Console.WriteLine("...|./.\\.|...");
            Console.WriteLine("...+-----+...");

        }

        private static void drawV(int num)
        {
            Console.WriteLine("...+-----+...");
            Console.WriteLine("...|\\.../|...");
            Console.WriteLine("{0:d2}.|.\\./.|...",num);
            Console.WriteLine("...|..V..|...");
            Console.WriteLine("...+-----+...");
        }

        private static void drawEmpty(int num)
        {
            Console.WriteLine("...+-----+...");
            Console.WriteLine("...|.....|...");
            Console.WriteLine("{0:d2}.|.....|...", num);
            Console.WriteLine("...|.....|...");
            Console.WriteLine("...+-----+...");
        }
    }
}
