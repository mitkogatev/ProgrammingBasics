using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
 
                int n = int.Parse(Console.ReadLine());
                int oddSum = 0;
                int evenSum = 0;
                for (int i = 0; i < n; i++)
                {
                    if (i%2==0)
                    evenSum += int.Parse(Console.ReadLine());
                    else
                        oddSum+= int.Parse(Console.ReadLine());
                }
                
               
                var result = Math.Abs(oddSum - evenSum);
                if (result == 0)
                    Console.WriteLine("Yes, sum = " + oddSum);
                else
                    Console.WriteLine("No, diff = " + result);
            }
        }
    }


