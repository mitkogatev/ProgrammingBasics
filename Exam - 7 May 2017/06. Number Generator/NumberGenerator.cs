using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_Generator
{
    class NumberGenerator
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());
            //17:06
            for (int i = m;  i>=1;i--)
            {
                for (int j = n; j>=1; j--)
                {
                    for (int z=l; z>=1; z--)
                    {
                        int number = int.Parse(i.ToString() + j.ToString() + z.ToString());
                        if (number % 3 == 0) specialNumber += 5;
                        else if (number % 10 == 5) specialNumber -= 2;
                        else if (number % 2 == 0) specialNumber *= 2;
                        if (specialNumber >= controlNumber)
                        {
                            Console.WriteLine($"Yes! Control number was reached! Current special number is {specialNumber}.");
                            return;
                        }
                    }
                }
            }
            Console.WriteLine($"No! {specialNumber} is the last reached special number.");
            
        }
    }
}
