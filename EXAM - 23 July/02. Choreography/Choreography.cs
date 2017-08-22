using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choreography
{
    class Choreography
    {
        static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int schoolDays = int.Parse(Console.ReadLine());

            var stepsPerDay = Math.Ceiling((((double)steps / schoolDays)/steps)*100);
            var stepsPerDancer = stepsPerDay / dancers;

            if (stepsPerDay<=13)
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancer:f2}%.");
            else
                Console.WriteLine($"No, They will not succeed in that goal! Required {stepsPerDancer:f2}% steps to be learned per day.");
        }
    }
}
