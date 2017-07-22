using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 2) Console.WriteLine("Not Prime");

            else {
                for (int i = 2; i < n; i++)
                {
                    if (n % i==0) 
                    {
                        Console.WriteLine("Not Prime");
                        return;
                    }

                }
                
            }
             Console.WriteLine("Prime");
        }
    }
}
