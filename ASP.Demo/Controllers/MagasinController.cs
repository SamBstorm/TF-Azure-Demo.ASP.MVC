using ASP.Demo.Handlers;
using ASP.Demo.Models;
using ASP.Demo.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Demo.Controllers
{
    public class MagasinController : Controller
    {
        private static List<Magasin> _magasins;

        public MagasinController()
        {
            if (_magasins is null)
            {
                _magasins = new List<Magasin>();
                _magasins.Add(new Magasin());
                _magasins[0].MagasinId = 1;
                _magasins[0].Nom = "Viens chez moi!";
                _magasins[0].Rue = "Rue de la montagne";
                _magasins[0].Numero = "255Bis";
                _magasins[0].CodePostal = "6000";
                _magasins[0].Ville = "Charleroi";
                _magasins[0].Pays = "Belgique";
                _magasins.Add(new Magasin());
                _magasins[1].MagasinId = 2;
                _magasins[1].Nom = "Tout presque gratuit";
                _magasins[1].Rue = "Avenue des cerisiers";
                _magasins[1].Numero = "255Bis";
                _magasins[1].CodePostal = "1000";
                _magasins[1].Ville = "Bruxelles";
                _magasins[1].Pays = "Belgique";
            }
        }

        // GET: MagasinController
        public ActionResult Index()
        {
            return View(_magasins.Select(m => m.ToListItem()));
        }

        // GET: MagasinController/Details/5
        public ActionResult Details(int id)
        {
            Magasin mag = _magasins.SingleOrDefault(m => m.MagasinId == id);
            return View(mag);
        }

        // GET: MagasinController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MagasinController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MagasinCreateForm form)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception("ModelState invalide");
                Magasin mag = form.ToMagasin();
                mag.MagasinId = _magasins.Max(m => m.MagasinId) + 1;
                _magasins.Add(mag);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(form);
            }
        }

        // GET: MagasinController/Edit/5
        public ActionResult Edit(int id)
        {
            Magasin mag = _magasins.SingleOrDefault(m => m.MagasinId == id);
            return View(mag);
        }

        // POST: MagasinController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MagasinController/Delete/5
        public ActionResult Delete(int id)
        {
            Magasin mag = _magasins.SingleOrDefault(m => m.MagasinId == id);
            return View(mag);
        }

        // POST: MagasinController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
