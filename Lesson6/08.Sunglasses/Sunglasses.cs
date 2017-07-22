using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstLastRow = new string('*', n*2);
            firstLastRow = firstLastRow + new string(' ', n) + firstLastRow;

            Console.WriteLine(firstLastRow);
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/',2*n-2));
                Console.Write("*");
                if (n % 2 == 0)
                
                    if (i == (n / 2)-1)
                        Console.Write(new string('|', n));
                        
                    else
                        Console.Write(new string(' ', n));

                else
                
                    if (i == n / 2 )
                        Console.Write(new string('|', n));
                    else
                        Console.Write(new string(' ', n));
                
                    Console.Write("*");
                
                Console.Write(new string('/', 2 * n - 2));
                Console.WriteLine("*");

            }
            Console.WriteLine(firstLastRow);
        }
    }
}
