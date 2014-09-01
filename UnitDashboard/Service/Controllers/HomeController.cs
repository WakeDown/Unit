using System.Web.Mvc;

namespace Service.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ExchangeRates()
        {
            ExchangeRates USDExchangeRates = new ExchangeRates("USD");
            ExchangeRates EURExchangeRates = new ExchangeRates("EUR");
            ExchangeRates CNYExchangeRates = new ExchangeRates("CNY");
            ViewData["USD"] = USDExchangeRates.rate;
            ViewData["EUR"] = EURExchangeRates.rate;
            ViewData["CNY"] = CNYExchangeRates.rate;

            return View();
        }

        [HttpGet]
        public ActionResult Weather()
        {
            Weather weather = new Weather("90210");

            return View(weather);
        }
    }
}
