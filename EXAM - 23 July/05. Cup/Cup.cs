using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Cup
{
    class Cup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int w = 5 * n;
            int dots = n;
            for (int i = 0; i < n+1; i++)
            {
                if (i<n/2)
                Console.WriteLine("{0}{1}{0}",new string('.',dots),new string('#',w-(dots*2)));
                else
                 Console.WriteLine("{0}#{1}#{0}", new string('.', dots), new string('.', w - 2-(dots * 2)));
                dots++;
            }
            dots--;
            Console.WriteLine("{0}{1}{0}",new string('.',dots), new string('#', w - (dots * 2)));
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}",new string('.', (w - n - 4) / 2),new string('#',n+4));
            }
            Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', (w-10)/2));
            for (int i = 0; i < n / 2 +1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', (w-n-4)/2), new string('#',n+4));
            }
        }
    }
}
