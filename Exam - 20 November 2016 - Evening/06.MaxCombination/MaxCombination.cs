using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxCombination
{
    class MaxCombination
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int maxCombo = int.Parse(Console.ReadLine());
            int currCombo = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    if (currCombo == maxCombo) return;
                    Console.Write($"<{i}-{j}>");
                    currCombo++;
                }
            }
            Console.WriteLine();
        }
    }
}
