using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._On_Time_for_the_Exam
{
    class OnTimefortheExam
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            //DateTime.Parse()
            string d = @"h\:mm";
            DateTime exam = DateTime.Parse(examHour.ToString()+":"+examMinute.ToString());
            DateTime arrival = DateTime.Parse(arrivalHour.ToString() + ":" + arrivalMinute.ToString());
            
            TimeSpan diff = (exam - arrival).Duration();
            
           // Console.WriteLine(diff);
            if (arrival > exam)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0}", diff.Hours != 0 ? diff.ToString(d) + " hours after the start" : diff.ToString("%m") + " minutes after the start");
            }
            else if (arrival <= exam && arrival >= exam.AddMinutes(-30))
            {
                Console.WriteLine("On Time");
                if (arrival != exam)
                    Console.WriteLine("{0}", diff.Hours != 0 ? diff.ToString(d) + " hours before the start" : diff.ToString("%m") + " minutes before the start");
            }
            else
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0}", diff.Hours != 0 ? diff.ToString(d) + " hours before the start" : diff.ToString("%m") + " minutes before the start");

            }

            //Console.WriteLine("{0} {1} {2}",exam,arrival,exam.AddMinutes(-30));
            //Console.WriteLine(exam);
        }
    }
}
