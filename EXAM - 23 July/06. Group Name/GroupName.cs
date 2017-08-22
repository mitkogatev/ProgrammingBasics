using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Group_Name
{
    class GroupName
    {
        static void Main(string[] args)
        {
            char s1 = char.Parse(Console.ReadLine().ToUpper());
            char s2 = char.Parse(Console.ReadLine().ToLower());
            char s3 = char.Parse(Console.ReadLine().ToLower());
            char s4 = char.Parse(Console.ReadLine().ToLower());
            int s5 = int.Parse(Console.ReadLine());

            int count = -1;
            for (char n1 = 'A'; n1 <= s1; n1++)
            {
                for (char n2 = 'a'; n2 <= s2; n2++)
                {
                    for (char n3 = 'a'; n3 <= s3; n3++)
                    {
                        for (char n4 = 'a'; n4 <= s4; n4++)
                        {
                            for (int n5 = 0; n5 <= s5; n5++)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
