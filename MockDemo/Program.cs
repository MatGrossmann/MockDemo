using BundesbankCurrencyCalculators;
using System;

namespace MockDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            EuroToDollarRechner etd = new EuroToDollarRechner() ;


            double ergebnis=etd.Euro2Dollar(10);
            Console.WriteLine(ergebnis);
        }
    }
}
