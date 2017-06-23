using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Trainers_Salary
{
    class TrainersSalary
    {
        static void Main(string[] args)
        {
            int lections = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            int jelev=0;
            int royal = 0;
            int roli = 0;
            int trofon = 0;
            int sino = 0;
            int others = 0;

            for (int i = 0; i < lections; i++)
            {
                switch (Console.ReadLine())
                {
                    case "Jelev": jelev++;break;
                    case "RoYaL": royal++;break;
                    case "Roli":roli++;break;
                    case "Trofon":trofon++;break;
                    case "Sino":sino++;break;
                    default:others++;break;
                }
 
            }
            Console.WriteLine($"Jelev salary: {budget / lections * jelev:f2} lv");
            Console.WriteLine($"RoYaL salary: {budget / lections * royal:f2} lv");
            Console.WriteLine($"Roli salary: {budget / lections * roli:f2} lv");
            Console.WriteLine($"Trofon salary: {budget / lections * trofon:f2} lv");
            Console.WriteLine($"Sino salary: {budget / lections * sino:f2} lv");
            Console.WriteLine($"Others salary: {budget / lections * others:f2} lv");
        }
    }
}
