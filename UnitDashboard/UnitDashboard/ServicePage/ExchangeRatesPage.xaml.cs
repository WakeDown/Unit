namespace UnitDashboard.widgets
{
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
