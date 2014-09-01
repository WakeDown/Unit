using System.Text.RegularExpressions;

namespace UnitDashboard
{
    class WeatherService
    {
        public WeatherService(string country, string city)
        {
            UnitDashboard.WeatherServiceReference.GlobalWeatherSoapClient client =
                new UnitDashboard.WeatherServiceReference.GlobalWeatherSoapClient("GlobalWeatherSoap");
            string str = client.GetWeather(city, country);

            this.country = Regex.Match(str, @"<Location>.+, (.+?) .+</Location>").Groups[1].Value;
            this.city = Regex.Match(str, @"<Location>(.+?),.+</Location>").Groups[1].Value;
            this.temperature = Regex.Match(str, @"<Temperature> (.+?)</Temperature>").Groups[1].Value;
            this.relativeHumidity = Regex.Match(str, @"<RelativeHumidity> (.*?)</RelativeHumidity>").Groups[1].Value;
            this.pressure = Regex.Match(str, @"<Pressure> (.+?)</Pressure>").Groups[1].Value;
        }
        public string country { get; set; }
        public string city { get; set; }
        public string temperature { get; set; }
        public string relativeHumidity { get; set; }
        public string pressure { get; set; }
    }
}
