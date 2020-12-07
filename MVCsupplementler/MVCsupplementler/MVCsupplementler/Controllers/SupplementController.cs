using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCsupplementler.Controllers
{
    public class SupplementController : Controller
    {
        // GET: Supplement
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int Id)
        {
            var suplament = Models.supplementveriler.VeriListe.Where(x => x.Id == Id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Models.supplementveriler supplementveriler)
        {
            var suplament = Models.supplementveriler.VeriListe.FirstOrDefault(x => x.Id == supplementveriler.Id);
            suplament.Ad = supplementveriler.Ad;
            suplament.Aroma = supplementveriler.Aroma;
            suplament.KG = supplementveriler.KG;
            suplament.Fiyat = supplementveriler.Fiyat;

            return RedirectToAction("Listele");
        }
        public ActionResult Delete(int Id)
        {
            var supplament = Models.supplementveriler.VeriListe.Where(x => x.Id == Id).FirstOrDefault();
            return View(supplament);
        }
        [HttpPost]
        public ActionResult Delete(Models.supplementveriler supplementveriler)
        {
            var suplament = Models.supplementveriler.VeriListe.FirstOrDefault(x => x.Id == supplementveriler.Id);
            Models.supplementveriler.VeriListe.Remove(suplament);
            return RedirectToAction("Listele");
        }
        public ActionResult Details(int Id)
        {
            var supplament = Models.supplementveriler.VeriListe.Where(x => x.Id == Id).FirstOrDefault();

            if (supplament == null)
            {
                return View("ürün yok");
            }
            else
            {
                return View("Suplement", supplament);
            }


        }
        [HttpPost]
        public ActionResult Details(Models.supplementveriler supplementveriler)
        {
            var supplament = Models.supplementveriler.VeriListe.FirstOrDefault(x => x.Id == supplementveriler.Id);
            Models.supplementveriler.VeriListe.Remove(supplament);
            return RedirectToAction("Listele");
        }

        public ActionResult Listele()
        {
            return View(Models.supplementveriler.VeriListe);
        }
    }
}