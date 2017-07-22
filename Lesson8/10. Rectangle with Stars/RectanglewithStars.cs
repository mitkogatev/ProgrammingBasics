using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Rectangle_with_Stars
{
    class RectanglewithStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int midLines = 0;
            if (n % 2 == 0) midLines = n - 1;
            else midLines = n;
            int w = n*2;
            Console.WriteLine(new string('%',w));
            for (int i = 0; i < midLines; i++)
            {
                if(i==midLines/2)
                    Console.WriteLine("%{0}**{0}%", new string(' ', (w - 4)/2));
                else
                    Console.WriteLine("%{0}%",new string(' ',w-2));
            }
            Console.WriteLine(new string('%',w));


        }
    }
}
