namespace UnitDashboard
{
    public partial class WeatherPage : System.Windows.Controls.Page
    {
        public WeatherPage()
        {
            
                InitializeComponent();
            try
            {
                WeatherService weather = new WeatherService("Russia", "Ekaterinburg");
                FBWeather_1.Text = weather.country;
                FBWeather_2.Text = weather.city;
                FBWeather_3.Text = weather.temperature;
                FBWeather_4.Text = weather.relativeHumidity;
                FBWeather_5.Text = weather.pressure;
            }
            catch
            {

            }
        }
    }
}
