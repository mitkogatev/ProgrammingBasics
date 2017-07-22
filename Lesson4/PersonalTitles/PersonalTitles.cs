using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            //// My Solution
            //double age = double.Parse(Console.ReadLine());
            //var gender =Console.ReadLine();
            //if (age >= 16)
            //{
            //    if (gender == "m")
            //        Console.WriteLine("Mr.");
            //    else
            //        Console.WriteLine("Ms.");
            //}
            //else
            //{
            //    if (gender == "m")
            //        Console.WriteLine("Master");
            //    else
            //        Console.WriteLine("Miss");
            //}
            /////////////////////
            var age = double.Parse(Console.ReadLine());
            var gender = Console.ReadLine();
            string personalTitle;

            //if (age < 16)
            //{
            //    personalTitle = gender == "m" ? "Master" : "Miss";//my sol
            //}
            //else
            //{
            //    personalTitle = gender == "m" ? "Mr." : "Ms."; //my sol
            //}
            //if (age < 16)
            //{
               // personalTitle = age <16 ? gender == "m" ? "Master" : "Miss" //;//my sol
           // }
           // else
           // {
               // : gender == "m" ? "Mr." : "Ms."; //my sol
                                                 // }
            personalTitle = age < 16 ? gender == "m" ? "Master" : "Miss" //;//my sol
                : gender == "m" ? "Mr." : "Ms."; //my sol


            Console.WriteLine(personalTitle);
        }
    }
}
