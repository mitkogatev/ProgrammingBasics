using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.On_Time_for_the_Exam
{
    class OnTimeForTheExam
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            var arrMin = arrivalHour * 60 + arrivalMinute;
            var exMin = examHour * 60 + examMinute;
            //8:30 exam //8:29 
            string msg = "";
            string msg2 = "";


            var diff = Math.Abs(exMin - arrMin);
            var h = diff / 60;
            var m = diff % 60;

            if (exMin >= arrMin)
            {
                if (diff <= 30)
                    msg = "On Time";
                else
                    msg = "Early";
                msg2 = "before the start";
            }
            else
            {
                msg = "Late";
                msg2 = "after the start";
            }

            Console.WriteLine(msg);
            if (diff != 0)
            {
                if (h!=0)
                    Console.WriteLine($"{h}:{m:00} hours {msg2}");
                else
                    Console.WriteLine($"{m} minutes {msg2}");

            }
        }
    }
}
