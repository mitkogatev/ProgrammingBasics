using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Encoded_Answers
{
    class EncodedAnswers
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            uint a = 0, b = 0, c = 0, d = 0;
            string result="";
            for (int i = 0; i < n; i++)
            {
                uint num= uint.Parse(Console.ReadLine());
                if (num%4==0)
                { result+="a "; a++; }
                else if (num % 4 == 1)
                { result+="b "; b++; }
                else if (num % 4 == 2)
                { result += "c "; c++; }
                else if (num % 4 == 3)
                { result += "d "; d++; }
            }
            Console.WriteLine(result);
            Console.WriteLine("Answer A: "+a);
            Console.WriteLine("Answer B: "+b);
            Console.WriteLine("Answer C: "+c);
            Console.WriteLine("Answer D: "+d);
        }
    }
}
