using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestePratico.Models;

namespace TestePratico.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(object populationData)
        {
            IEnumerable<PopulationData> populationDataList = GetPopulationData();
            return View(model: populationData);
        }


        public IEnumerable<PopulationData>  GetPopulationData()
        {
            throw new NotImplementedException();
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
