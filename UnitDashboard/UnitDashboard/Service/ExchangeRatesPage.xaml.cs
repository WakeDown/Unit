using System;
namespace UnitDashboard.widgets
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

    public partial class ExchangeRatesPage : System.Windows.Controls.Page
    {
        public ExchangeRatesPage()
        {
           
            InitializeComponent();

            try
            {
                ExchangeRatesService CHF = new ExchangeRatesService("CHF");
                ExchangeRatesService USD = new ExchangeRatesService("USD");
                ExchangeRatesService EUR = new ExchangeRatesService("EUR");
                ExchangeRatesService JPY = new ExchangeRatesService("JPY");
                ExchangeRatesService AUD = new ExchangeRatesService("AUD");
                FBExchangeRates_1.Text = System.Convert.ToString(CHF.rate);
                FBExchangeRates_2.Text = System.Convert.ToString(USD.rate);
                FBExchangeRates_3.Text = System.Convert.ToString(EUR.rate);
                FBExchangeRates_4.Text = System.Convert.ToString(JPY.rate);
                FBExchangeRates_5.Text = System.Convert.ToString(AUD.rate);
            }
            catch
            {

            }
        }
    }
}
