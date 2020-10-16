using BundesbankCurrencyCalculators;
using System;
using System.Collections.Generic;
using System.Text;

namespace BundesbankCurrencyCalculators
{
    public class WechselKursImpl:IWechselKursService
    {
        public double FindeWechselKurs(string currencyFrom, string currencyTo)
        {
            return 1.1;
        }
    }
}
