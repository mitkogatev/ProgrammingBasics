using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvadrat_ot_zvezdi4ki
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                if (i == 1 | i == n)
                {
                    string ch = "";
                    for (var j = 1; j <= n; j++)
                    {
                        ch = ch + "*";
                    }
                    Console.WriteLine(ch);
                }
                else
                {
                    string ch = "";
                    for (var j = 1; j <= n; j++)
                    {
                        if (j == 1 | j == n)
                        {
                            ch = ch + "*";
                        }
                        else
                        {
                            ch = ch + " ";
                        }
                    }
                    Console.WriteLine(ch);
                }
            }
        }
    }
}
