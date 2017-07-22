using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.StupidPasswordGenerator
{
    class StupidPassword
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int s1 = 1; s1 <= n; s1++)
            {
                for (int s2 = 1; s2 <= n; s2++)
                {
                    for (char s3 = (char)97; s3 <= l+96; s3++)
                    {
                        for (char s4 = (char)97; s4 <= l + 96; s4++)
                        {
                            for (int s5 = 1; s5 <= n; s5++)
                            {
                                if(s5>s1 && s5>s2)
                                    Console.Write($"{s1}{s2}{s3}{s4}{s5} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
