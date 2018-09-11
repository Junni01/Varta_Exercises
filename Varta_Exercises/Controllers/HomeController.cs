using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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


        public ActionResult Index()
        {
            var tuotteet = _tuoteDb.Tuotteet;
            return View(tuotteet); 
        }

        // Lähetetään viesti viewiin täytetty viesti-modeli jonka data on saatu lomakkeesta.
        //[HttpPost]
        //public ActionResult Viesti(Viesti viesti)
        //{

           
        //    var uusiViesti = viesti; // Tämä on turha.

        //    return View(uusiViesti);
        //}

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