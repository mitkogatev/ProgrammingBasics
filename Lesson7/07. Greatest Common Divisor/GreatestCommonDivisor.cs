﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (b > 0)
            {
                var oldb = b;
                b = a % b;
                a = oldb;
            }
            Console.WriteLine(a);
        }
    }
}
