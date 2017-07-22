using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int rows = num / 100 + (num/10)%10;// + num % 100;
            int cols = num / 100 + num % 10;
            int fd = num / 100;
            int sd = (num / 10) % 10;
            int ld = num % 10;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (num % 5 == 0) num -=fd;
                    else if (num % 3 == 0) num -= sd;
                    else num += ld;
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
           // Console.WriteLine(cols);
        }
    }
}
