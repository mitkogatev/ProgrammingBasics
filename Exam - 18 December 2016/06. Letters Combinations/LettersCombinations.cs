using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Letters_Combinations
{
    class LettersCombinations
    {
        static void Main(string[] args)
        {
            var startLetter = char.Parse(Console.ReadLine());
            var endLetter = char.Parse(Console.ReadLine());
            var skipLetter = char.Parse(Console.ReadLine());
            int counter = 0;
            //string result = "";
            for (var i = startLetter; i <= endLetter; i++)
            {
                if (i == skipLetter) continue;
                for (var j = startLetter; j <= endLetter; j++)
                {
                    if (j == skipLetter) continue;
                    for (var k = startLetter; k <= endLetter; k++)
                    {
                        if (k == skipLetter) continue;
                        Console.Write($"{i}{j}{k} ");
                        counter++;

                    }

                }
            }

            Console.WriteLine(counter);
        }
    }
}
