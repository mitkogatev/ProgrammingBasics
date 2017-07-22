using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_Frame
{
    class SquareFrame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string firstLastRow = "+ ";//"+ " + new string('-', n - 2) + " +";
            for (int i = 0; i < n-2; i++)
            {
                firstLastRow += "- ";
            }
            firstLastRow += "+";
            Console.WriteLine(firstLastRow);
            for (int i = 0; i < n-2; i++)
            {
                string midRow = "| ";//"+ " + new string('-', n - 2) + " +";
                for (int j = 0; j < n - 2; j++)
                {
                    midRow += "- ";
                }
                midRow += "|";
                Console.WriteLine(midRow);
            }
            Console.WriteLine(firstLastRow);

            //string firstLastRow = "{0}","5";//"+ " + new string('-', n - 2) + " +";

            //for (int i = 1; i <= n; i++)
            //{
            //    if (i==1||i==n)
            //        Console.WriteLine(firstLastRow);
            //    else
            //        Console.WriteLine("|"+new string('-',n-2)+"|");
            //}
        }
    }
}
