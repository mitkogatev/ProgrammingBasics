using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triangle_of_Dollars
{
    class TriangleOfDollars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("$ ");
            //    }
            //    Console.WriteLine();
            //}
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(FormString("$ ",i));
            }
            
        }
        public static string FormString(string stringParam, int number)
        {
            StringBuilder stringBuild = new StringBuilder();
            for (int i = 1; i <= number; i++)
            {
                stringBuild.Append(stringParam);
                //stringBuild.Append(" ");

            }
            return stringBuild.ToString();
        }
    }
}
