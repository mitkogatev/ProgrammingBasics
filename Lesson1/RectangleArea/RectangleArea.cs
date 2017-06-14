using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            //!!!!!!!!!! mass comment ctrl+k+c

            //var a = 5;
            //var b = 7;
            //Console.WriteLine(a*b);
            var a = decimal.Parse(Console.ReadLine());
            var b = decimal.Parse(Console.ReadLine());
            var result = a * b;
            Console.WriteLine(result.ToString());

            //!!!!!!!!!!!!!!!!
            //Console.WriteLine("\"tweets\"");
            //Console.WriteLine(@"""tweets""");
            
        }
    }
}
