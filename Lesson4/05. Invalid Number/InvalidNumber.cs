using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Invalid_Number
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (! (n==0 || (n>=100 && n<=200)) )
                Console.WriteLine("invalid");
        }
    }
}
