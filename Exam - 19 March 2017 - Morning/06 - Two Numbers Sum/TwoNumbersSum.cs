using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Two_Numbers_Sum
{
    class TwoNumbersSum
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = startNumber; i >= endNumber; i--)
            {
                for (int j = startNumber; j >= endNumber; j--)
                {
                    counter++;
                    if (i + j == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{counter} combinations - neither equals { magicNumber}");
        }
    }
}
