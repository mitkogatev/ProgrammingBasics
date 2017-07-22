using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Increasing_Elements
{
    class IncreasingElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int oldNum = 0;
            int longest = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > oldNum) {
                    count++;
                }
                else
                {
                    //if (longest <= count) { longest = count; }
                    count = 1;
                }
                if (count>longest) { longest = count; }
                oldNum = num;
            }
            Console.WriteLine(longest);
        }
    }
}
