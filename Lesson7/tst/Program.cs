using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.MagicNumbers
{
    class MagicNumbers
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());
            int sum = 1;
            int n = 0;
            
            for (int i = 111111; i <= 999999; i++)
            {
                sum = 1;
                n = i;
                while (n > 0)
                { 
                    sum *= n % 10;
                n = n / 10;
                 }
                
                if (sum == magicNumber) Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
