using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Varta_Exercises.Models;

namespace Varta_Exercises.Controllers
{
    public class HomeController : Controller
    {
        private TuoteDBContext _tuoteDb;


        public HomeController()
        {
            _tuoteDb = new TuoteDBContext();
        }

        protected override void Dispose(bool disposing)
        {
            _tuoteDb.Dispose();
        }


        public ActionResult Index(int? id)
        {

            Tuote valittu;

            if (!(id == null))
            {
               valittu = _tuoteDb.Tuotteet.SingleOrDefault(t => t.Tuotenumero == id);
                
              

            } else
            {
              valittu = new Tuote { Tuotenumero = 0, Nimi = " ", Kategoria = " ", Muokattu = DateTime.Now, Kuvaus = " ", Hinta = 0 };
            }
 


            

            ViewBag.tuotteet = _tuoteDb.Tuotteet;
            return View(valittu); 
        }




        // Lähetetään viesti viewiin täytetty viesti-modeli jonka data on saatu lomakkeesta.
        [HttpPost]
        public ActionResult Talleta(Tuote tuote)
        {
            if (!(tuote.Tuotenumero == 0)) {
                var paivitettavaTuote = _tuoteDb.Tuotteet.Single(t => t.Tuotenumero == tuote.Tuotenumero);

                TryUpdateModel(paivitettavaTuote);

                _tuoteDb.SaveChanges();

            }

            

            return RedirectToAction("Index", "Home");
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}