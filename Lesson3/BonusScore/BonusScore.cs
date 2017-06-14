using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonusPoints = 0;
             if  (number > 1000)
            {
                bonusPoints = number * 0.10;
            }
            
            else if (number > 100)
            {
                bonusPoints = number * 0.20;
            }
            else //(number <= 100)
            {
                bonusPoints = 5;
            }

            if (number %2==0)
            {
                bonusPoints += 1;
            }
            //if (number.ToString().EndsWith("5")) //mySolution
            //{
            //    bonusPoints += 2;
            //}
            if (number % 10 ==5)
            {
                bonusPoints += 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(number+bonusPoints);
        }
    }
}
