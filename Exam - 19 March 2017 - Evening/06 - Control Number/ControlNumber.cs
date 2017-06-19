using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Control_Number
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int m =int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine()); 
            int sum = 0;
            int mov = 0;
            for (int i = 1; i <= n; i++)
            {
                //mov++;
                for (int j = m; j >= 1; j--)
                {
                    mov++;
                    sum += i * 2 + j * 3;
                    if (sum >= controlNumber)
                    {
                        Console.WriteLine($"{mov} moves");
                        Console.WriteLine($"Score: {sum} >= {controlNumber}");
                        return;
                    }
                }
            }
            if (sum<controlNumber)Console.WriteLine($"{mov} moves");
        }
    }
}
