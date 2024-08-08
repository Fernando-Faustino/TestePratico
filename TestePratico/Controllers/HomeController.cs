using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TestePratico.Models;

namespace TestePratico.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< HEAD

        public IActionResult Index(object populationData)
        {
            IEnumerable<PopulationData> populationDataList = GetPopulationData();
            return View(model: populationData);
        }


        public IEnumerable<PopulationData>  GetPopulationData()
        {
            throw new NotImplementedException();
=======
        public IActionResult Index()
        {
            return View("Home/Index.cshtml");
>>>>>>> 5868f0de163b3be58ec78d2ec93324d93bf5cf74
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
