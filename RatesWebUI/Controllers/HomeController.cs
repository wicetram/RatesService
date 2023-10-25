using RatesWebUI.RateService;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RatesWebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (RateServiceClient client = new RateServiceClient())
            {
                if (TempData["rates"] != null)
                {
                    ViewBag.Rates = TempData["rates"] as List<double>;
                }
                else
                {
                    ViewBag.Rates = new List<double>();
                }

                var modal = client.GetCurrencies().ToList();
                return View(modal);
            }
        }

        public ActionResult GetRates(string currencies)
        {
            using (RateServiceClient client = new RateServiceClient())
            {
                var modal = client.GetRates(currencies).ToList();
                TempData["rates"] = modal;
                return RedirectToAction("Index");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}