using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Salt_And_Pepper
{
    class SaltAndPepper
    {
        static void Main(string[] args)
        {
             ulong num = ulong.Parse(Console.ReadLine());
            var bits = Convert.ToString((long)num, 2);
            bits = bits.PadLeft(64, '0'); //add leading zeroes
            var arr = bits.ToCharArray();
            string input = "";
            while (input != "end")
            {
                input = Console.ReadLine();
                if (input == "end") break;
                var line = input.Split(' ');
                var spice = line[0].ToLower();uint step = uint.Parse(line[1]);

                for (int i = arr.Length - 1; i >= 0; i-=(int)step)
                {
                    if (step == 0) break;
                    if (spice == "salt")
                    {
                        if (arr[i] == '1') arr[i] = '0';
                    }else if (spice == "pepper") { if (arr[i] == '0') arr[i] = '1'; }
                }
            }
            string s = new string(arr);
            ulong endnum = Convert.ToUInt64(s,2);
            Console.WriteLine(endnum);

        }
    }
}
