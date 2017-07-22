using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sudoku_Results
{
    class SudokuResults
    {
        static void Main(string[] args)
        {
            string input = "";//Console.ReadLine();
            int games = 0;
            int sumSeconds = 0;
            while (input!= "Quit")
            {
                input = Console.ReadLine();
                if (input == "Quit") break;
                var line = input.Split(':');
                sumSeconds += int.Parse(line[0]) * 60 + int.Parse(line[1]);
                games++;
            }
            //Console.WriteLine($"tot:{sumSeconds};ga:{games};avg:{sumSeconds/games}");
            var avg = Math.Ceiling(sumSeconds / (double)games);
            string star = "";
            if (avg < 720) star = "Gold";
            else if (avg >= 720 && avg <= 1440) star = "Silver";
            else star = "Bronze";
            Console.WriteLine($"{star} Star");
            Console.WriteLine($"Games - {games} \\ Average seconds - {avg}");
        }
    }
}
