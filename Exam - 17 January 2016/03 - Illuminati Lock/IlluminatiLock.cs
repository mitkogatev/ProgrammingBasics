using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Illuminati_Lock
{
    class IlluminatiLock
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int h = n + 1;
            int w = 3 * n;
            Console.WriteLine("{0}{1}{0}",new string('.',n),new string('#',n));
            int ld = n - 2;
            int md =0;

            for (int i = 0; i < (h-2)/2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}",new string('.',ld),new string('.',md), new string('.', n-2));
                ld -= 2;
                md += 2;
            }
            ld += 2;
            md -= 2;
            for (int i = 0; i < (h - 2) / 2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', ld), new string('.', md), new string('.', n - 2));
                ld += 2;
                md -= 2;
            }
            Console.WriteLine("{0}{1}{0}",new string('.',n),new string('#',n));
        }
    }
}
