using System;
using System.Collections.Generic;
using System.Text;

namespace BundesbankCurrencyCalculators
{
    public class EuroToDollarRechner
    {
        //Property
        public IWechselKursService Service { get; }

        //Konstruktor
        public EuroToDollarRechner(IWechselKursService service)
        {
            Service = service;
        }


        public double Euro2Dollar(double euro)
        {
            IWechselKursService service = new WechselKursImpl();
            double kurs = Service.FindeWechselKurs("USD", "EUR");
            return euro * kurs;
        }



    }
}
