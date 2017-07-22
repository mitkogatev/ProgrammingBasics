using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Shuffle_Bits
{
    class ShuffleBits
    {
        static void Main(string[] args)
        {
            uint n1 = uint.Parse(Console.ReadLine()); 
            uint n2 = uint.Parse(Console.ReadLine());
            var bits1 = Convert.ToString(n1, 2).PadLeft(32,'0');
            var bits2 = Convert.ToString(n2, 2).PadLeft(32, '0');
            //Console.WriteLine(bits1);
            //Console.WriteLine(bits2);
            var num = "";
            if (n1 >= n2)
            {
                while (num.Length < 64)
                {
                    num += bits1[0];
                    num += bits2[0];
                    bits1 = bits1.Remove(0, 1);
                    bits2 = bits2.Remove(0, 1);
                }
            }
            else
            {
                while (num.Length < 64)
                {
                    num += bits1[0];
                    num += bits1[1];

                    num += bits2[0];
                    num += bits2[1];
                    bits1 = bits1.Remove(0, 2);
                    bits2 = bits2.Remove(0, 2);
                }
            }
            //Console.WriteLine(num);
            var z = Convert.ToUInt64(num, 2);
            Console.WriteLine(z);

        }
    }
}
