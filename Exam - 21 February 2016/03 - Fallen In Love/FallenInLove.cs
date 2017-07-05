using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___Fallen_In_Love
{
    class FallenInLove
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int w = 4 * num + 6;
            int startDots = 2 * num;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("#{0}#{1}#{2}#{1}#{0}#",new string('~',i),new string('.',startDots),new string('.',2*i));
                startDots -= 2;
            }
            int midDots = 2 * num;
            startDots = 1;
            for (int i = num; i >0; i--)
            {
                Console.WriteLine("{0}#{1}#{2}#{1}#{0}",new string('.',startDots),new string('~',i),new string('.',midDots));
                startDots += 2;
                midDots -= 2;
            }
            Console.WriteLine("{0}####{0}",new string('.',(w-4)/2));
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0}##{0}", new string('.', (w - 2)/2));

            }
        }
    }
}
