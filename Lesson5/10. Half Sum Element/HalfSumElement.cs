using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
                if (currentNumber > max) max = currentNumber;
            }
            if (Math.Abs(sum-max)==max)
                Console.WriteLine("Yes, sum = " + Math.Abs(sum - max));
            else
                Console.WriteLine("No, diff = " + Math.Abs((sum-max) - max));
        }
    }
}
