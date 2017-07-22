using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            for (int i = 0; i < n; i++)
            {
                leftSum+= int.Parse(Console.ReadLine());
            }
            int rightSum = 0;
            for (int i = 0; i < n; i++)
            {
                rightSum+= int.Parse(Console.ReadLine());

            }
            var result = Math.Abs(leftSum - rightSum);
            if (result==0)
                Console.WriteLine("Yes, sum = "+leftSum);
            else
                Console.WriteLine("No, diff = "+result);
        }
    }
}
