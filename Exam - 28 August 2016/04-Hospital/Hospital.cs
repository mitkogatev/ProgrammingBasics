using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int pregledani = 0;
            int nepregledani = 0;

            for (int i = 1; i <= period; i++)
            {
                int pacients = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && nepregledani > pregledani) doctors++;
                if (pacients <= doctors) pregledani += pacients;
                else { pregledani += doctors; nepregledani += pacients - doctors; }

            }
            Console.WriteLine($"Treated patients: {pregledani}.");
            Console.WriteLine($"Untreated patients: {nepregledani}.");

        }
    }
}
