using CountriesApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CountriesApp.Controllers
{
    public class HomeController : Controller
    {
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<Country> countres = new List<Country>();
            client.BaseAddress = new Uri("https://restcountries.com/v3.1/all");
            var responce = client.GetAsync("");

            var test = responce.Result;
            if(test.IsSuccessStatusCode) 
            {
                var display = test.Content.ReadFromJsonAsync<List<Country>>();
                countres = display.Result;
            }
            return View(countres);
        }
        public ActionResult Details(string id)
        {

            List<Country> country = new List<Country>();
            client.BaseAddress = new Uri("https://restcountries.com/v3.1/name/"+ id);
            var responce = client.GetAsync("");

            var test = responce.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadFromJsonAsync<List<Country>>();
                country = display.Result;
            }
            return View(country);
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}