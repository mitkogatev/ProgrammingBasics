using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            double commisions = -1;
            if (town == "sofia")
            {
                if (0 <= sales && sales <= 500) commisions = 0.05;
                else if (500 < sales && sales <= 1000) commisions = 0.07;
                else if (1000 < sales && sales <= 10000) commisions = 0.08;
                else if (sales >10000) commisions = 0.12;
            }
            else if (town == "varna")
            {
                if (0 <= sales && sales <= 500) commisions = 0.045;
                else if (500 < sales && sales <= 1000) commisions = 0.075;
                else if (1000 < sales && sales <= 10000) commisions = 0.1;
                else if (sales > 10000) commisions = 0.13;
            }
            else if (town == "plovdiv")
            {
                if (0 <= sales && sales <= 500) commisions = 0.055;
                else if (500 < sales && sales <= 1000) commisions = 0.08;
                else if (1000 < sales && sales <= 10000) commisions = 0.12;
                else if (sales > 10000) commisions = 0.145;
            }

            if (commisions < 0) Console.WriteLine("error");

            //else Console.WriteLine("error");
            else
            Console.WriteLine(sales*commisions);

        }
    }
}
