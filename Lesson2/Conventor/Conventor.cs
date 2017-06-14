using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conventor
{
    class Conventor
    {
        static void Main(string[] args)
        {
            var usd = decimal.Parse(Console.ReadLine());
            var bgn = usd * 1.79549m;
            Console.WriteLine("{0:f2} BGN",bgn);
        }
    }
}
