using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers_Ending_in_7
{
    class NumbersEndingIn7
    {
        static void Main(string[] args)
        {
            //v1
            //for (int i = 7; i < 1000; i+=10)
            //{
            //    Console.WriteLine(i);
            //}

            //v2
            for (int i = 7; i <= 1000; i++)
            {
                if(i%10==7)
                    Console.WriteLine(i);
            }
        }
    }
}
