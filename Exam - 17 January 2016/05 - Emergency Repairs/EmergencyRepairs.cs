using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Emergency_Repairs
{
    class EmergencyRepairs
    {
        static void Main(string[] args)
        {
            var startWall = Convert.ToString((long)ulong.Parse(Console.ReadLine()), 2);
            startWall = startWall.PadLeft(64, '0');
            var wall = startWall.ToCharArray();
            uint emgKits = uint.Parse(Console.ReadLine());
            uint numAttacks = uint.Parse(Console.ReadLine());
            for (int i = 0; i < numAttacks; i++)
            {
                uint attackedBit = uint.Parse(Console.ReadLine());
                var ab = Math.Abs((int)attackedBit - 63);
                if (wall[ab] == '1') wall[ab] = '0';
            }
            //repairs
            // Console.WriteLine(new string(wall));
            for (int i = wall.Length - 1; i > 0; i--)
            {
                if (wall[i] == '0' && wall[i - 1] == '0')
                {
                    if (emgKits >= 2)
                    {
                        //wall[i] = '1';
                        // wall[i - 1] = '1';
                        // emgKits -= 2;
                        int c = i;
                        do
                        {
                            wall[c] = '1';
                            emgKits--;
                            c--;
                            if (emgKits == 0) break;
                        } while (wall[c] == '0' && c >= 0);
                    }
                    else if (emgKits == 1) { wall[i] = '1'; emgKits = 0; }

                }
                if (emgKits == 0) break;
            }
            //Console.WriteLine(new string(wall));

            var endWall = Convert.ToUInt64(new string(wall), 2);
            Console.WriteLine(endWall);
        }
    }
}
