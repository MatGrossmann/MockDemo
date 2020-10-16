namespace BundesbankCurrencyCalculators
{
    public interface IWechselKursService
    {
        public double FindeWechselKurs(string currencyFrom, string currencyTo);  //keine Imlementierungsklammern!!!
    }
}