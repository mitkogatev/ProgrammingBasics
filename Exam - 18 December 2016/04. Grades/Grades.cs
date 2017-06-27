using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());
            int top = 0;
            int four = 0;
            int three = 0;
            int fail = 0;
            double avg = 0.0;
            for (int i = 0; i < numStudents; i++)
            {
                double grade=double.Parse(Console.ReadLine());
                if (grade >= 5.00)
                    top++;
                else if (grade >= 4.00 && grade < 5.00)
                    four++;
                else if (grade >= 3.00 && grade < 4.00)
                    three++;
                else if (grade >= 2.00 && grade < 3)
                    fail++;
                avg += grade;
            }

            Console.WriteLine($"Top students: {(double)top/numStudents * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double)four / numStudents * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double)three / numStudents * 100:f2}%");
            Console.WriteLine($"Fail: {(double)fail / numStudents * 100:f2}%");
            Console.WriteLine($"Average: {avg / numStudents:f2}");


        }
    }
}
