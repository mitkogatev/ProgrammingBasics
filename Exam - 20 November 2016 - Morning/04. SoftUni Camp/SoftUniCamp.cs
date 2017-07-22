using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int car = 0;int microbus = 0;int smallBus = 0;
            int bigBus = 0;int train = 0;
            int allPeople = 0;
            for (int i = 0; i < groups; i++)
            {
                int people= int.Parse(Console.ReadLine());
                if (people < 6) car+=people;
                if (people >= 6 && people <= 12) microbus+=people;
                if (people >= 13 && people <= 25) smallBus+=people;
                if (people >= 26 && people <= 40) bigBus+=people;
                if (people >= 41) train+=people;
                allPeople += people;
            }
            Console.WriteLine($"{(double)car/allPeople*100:f2}%");
            Console.WriteLine($"{(double)microbus/allPeople*100:f2}%");
            Console.WriteLine($"{(double)smallBus/allPeople*100:f2}%");
            Console.WriteLine($"{(double)bigBus/allPeople*100:f2}%");
            Console.WriteLine($"{(double)train/allPeople*100:f2}%");
        }
    }
}
