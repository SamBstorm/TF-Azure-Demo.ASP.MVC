using ASP.Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (TempData.ContainsKey("colorTheme")) TempData.Keep("colorTheme");
            return View();
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

        public IActionResult AddTask(string task)
        {
            bool isRecorded = false;
            for (int i = 0; i < 20 && !isRecorded; i++)
            {
                if(!TempData.ContainsKey($"Task{i}")){
                    TempData[$"Task{i}"] = task;
                    isRecorded = true;
                }
            }
            return RedirectToAction(nameof(ViewTask));
        }

        public IActionResult ViewTask() {
            if (TempData.Count > 0) TempData.Keep();
            return View();
        }

        public IActionResult ClearTasks() {
            object? o;
            for (int i = 0; i < 20; i++)
            {
                if (TempData.ContainsKey($"Task{i}")) o = TempData[$"Task{i}"];
            }
            return Ok();
        }

        public IActionResult AboutUs()
        {
            Entreprise model = new Entreprise();
            model.Nom = "Au bon marché!";
            model.ContactMail = "info@abm.com";
            model.ContactPhone = "+3280033800";
            model.magasins = new Magasin[2];
            model.magasins[0] = new Magasin();
            model.magasins[0].Nom = "Viens chez moi!";
            model.magasins[0].Rue = "Rue de la montagne";
            model.magasins[0].Numero = "255Bis";
            model.magasins[0].CodePostal = "6000";
            model.magasins[0].Ville = "Charleroi";
            model.magasins[0].Pays = "Belgique";
            model.magasins[1] = new Magasin();
            model.magasins[1].Nom = "Tout presque gratuit";
            model.magasins[1].Rue = "Avenue des cerisiers";
            model.magasins[1].Numero = "255Bis";
            model.magasins[1].CodePostal = "1000";
            model.magasins[1].Ville = "Bruxelles";
            model.magasins[1].Pays = "Belgique";
            return View(model);
        }

        public IActionResult convertToHTML ()
        {
            return View();
        }
        [HttpPost]
        public IActionResult convertToHTML(string text)
        {
            object model = text;
            return View(model);
        }

        public IActionResult SetBlack()
        {
            TempData["colorTheme"] = "_LayoutBlack";
            return RedirectToAction("Index");
        }
        public IActionResult SetWhite()
        {
            TempData.Remove("colorTheme");
            return RedirectToAction("Index");
        }

        public IActionResult WithCSSCustom()
        {
            return View();
        }

        public IActionResult WithoutCSSCustom()
        {
            return View();
        }

    }
}