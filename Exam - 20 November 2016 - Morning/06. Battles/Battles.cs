using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Battles
    {
        static void Main(string[] args)
        {
            int firstPokemons = int.Parse(Console.ReadLine());
            int secondPokemons = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <=firstPokemons; i++)
            {
                for (int j = 1; j <= secondPokemons; j++)
                {
                    counter++;
                    Console.Write($"({i} <-> {j}) ");
                    if (counter == maxBattles) return;
                }
            }
            Console.WriteLine();
        }
    }
}
