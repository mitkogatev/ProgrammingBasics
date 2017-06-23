using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Alcohol_Market
{
    class AlcoholMarket
    {
        static void Main(string[] args)
        {
            
            double whiskeyPricePerLiter = double.Parse(Console.ReadLine());
            double beerQty= double.Parse(Console.ReadLine());
            double wineQty = double.Parse(Console.ReadLine());
            double rakiaQty = double.Parse(Console.ReadLine());
            double whiskeyQty = double.Parse(Console.ReadLine());

            var rakiaPricePerLiter = whiskeyPricePerLiter / 2;
            var winePricePerLiter = rakiaPricePerLiter *0.6;
            var beerPricePerLiter = rakiaPricePerLiter * 0.2;

            Console.WriteLine("{0:f2}",whiskeyPricePerLiter*whiskeyQty+beerPricePerLiter*beerQty+rakiaPricePerLiter*rakiaQty+winePricePerLiter*wineQty);
            
            
        }
    }
}
