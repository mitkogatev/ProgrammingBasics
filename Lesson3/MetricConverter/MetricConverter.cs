using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            var size = double.Parse(Console.ReadLine());
            var sourceMetric = Console.ReadLine().ToLower();
            var input = sourceMetric;
            var destMetric = Console.ReadLine().ToLower();
            var output = destMetric;
            if (sourceMetric == "m")
            {
                input = input.Replace("m", "1");
            }
            if (destMetric == "m")
            {
                output = output.Replace("m", "1");
            }
           input = input.Replace("mm", "1000");
           input=input.Replace("cm", "100");
           input=input.Replace("mi", "0.000621371192");
           input=input.Replace("in", "39.3700787");
           input=input.Replace("km", "0.001");
           input=input.Replace("ft", "3.2808399");
           input=input.Replace("yd", "1.0936133");
            ///
            output = output.Replace("mm", "1000");
            output = output.Replace("cm", "100");
            output = output.Replace("mi", "0.000621371192");
            output = output.Replace("in", "39.3700787");
            output = output.Replace("km", "0.001");
            output = output.Replace("ft", "3.2808399");
            output = output.Replace("yd", "1.0936133");

            Console.WriteLine($"{size / double.Parse(input) * double.Parse(output):F8} ");       
        }
    }
}
