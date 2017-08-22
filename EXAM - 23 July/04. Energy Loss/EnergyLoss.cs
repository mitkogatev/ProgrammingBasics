using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Energy_Loss
{
    class EnergyLoss
    {
        static void Main(string[] args)
        {
            int trainDays = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            var wasedEnergy = 0;
            for (int i = 1; i <= trainDays; i++)
            {
                int trainHours = int.Parse(Console.ReadLine());
                if (i % 2 == 0 && trainHours % 2 == 0)
                    wasedEnergy += dancers * 68;
                else if (i % 2 != 0 && trainHours % 2 == 0)
                    wasedEnergy += dancers * 49;
                else if (i % 2 == 0 && trainHours % 2 != 0)
                    wasedEnergy += dancers * 65;
                else if (i % 2 != 0 && trainHours % 2 != 0)
                    wasedEnergy += dancers * 30;
            }
            var energy = 100 * dancers * trainDays;
            var energyLeft = energy - wasedEnergy;
            var energyLeftPerDancer = (double)energyLeft / dancers / trainDays;
            if (energyLeftPerDancer>50)
                Console.WriteLine($"They feel good! Energy left: {energyLeftPerDancer:f2}");
            else
                Console.WriteLine($"They are wasted! Energy left: {energyLeftPerDancer:f2}");
        }
    }
}
