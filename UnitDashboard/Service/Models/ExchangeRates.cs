using System;

namespace Service.Controllers
{
    class ExchangeRates
    {
        public ExchangeRates(string Currency)
        {
            Service.ServiceReferenceExchangeRates.ExchangeRatesSoapClient client = new Service.ServiceReferenceExchangeRates.ExchangeRatesSoapClient("ExchangeRatesSoap");
            Decimal thisRate = client.getCurrentExchangeRate(Currency);
            Decimal rubRate = client.getCurrentExchangeRate("RUB");
            this.rate = (float)Math.Round(thisRate / rubRate, 4);
        }
        public float rate { get; set; } 
    }
}
