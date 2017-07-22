using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Stupid_Password_Generator
{
    class StupidPasswordGenerator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int i1 = 1; i1 <= n; i1++)
            {
                for (int i2 = 1; i2 <= n; i2++)
                {
                    for (char i3 = 'a'; i3 <= l+96; i3++)
                    {
                        for (char i4 = 'a'; i4 <= l+96; i4++)
                        {
                            for (int i5 = 1; i5 <= n; i5++)
                            {
                                if(i5>i2 && i5>i1)
                                Console.Write($"{i1}{i2}{i3}{i4}{i5} ");

                            }
                        }
                    }
                }
            }
        }
    }
}
