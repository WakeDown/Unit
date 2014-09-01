using System;

namespace UnitDashboard
{
    class ExchangeRatesService
    {
        public ExchangeRatesService(string Currency)
        {
            UnitDashboard.ExchangeRatesServiceReference.ExchangeRatesSoapClient client = 
                new UnitDashboard.ExchangeRatesServiceReference.ExchangeRatesSoapClient("ExchangeRatesSoap");
            Decimal thisRate = client.getCurrentExchangeRate(Currency);
            Decimal rubRate = client.getCurrentExchangeRate("RUB");
            this.rate = (float)Math.Round(thisRate / rubRate, 4);
        }
        public float rate { get; set; }
    }
}
