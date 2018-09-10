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
        public ActionResult Index()
        {




            var henkilot = new List<Henkilo>(); // Luodaan listi Henkilöiost johon lisätään dataa.

            henkilot.Add(new Henkilo { ID = 1, ENimi = "Saku", SNImi = "Junni", Pisteet = 20});
            henkilot.Add(new Henkilo { ID = 2, ENimi = "Pekka", SNImi = "Levänen", Pisteet = 27});
            henkilot.Add(new Henkilo { ID = 3, ENimi = "Jukka", SNImi = "Raatikainen", Pisteet = 23});
            henkilot.Add(new Henkilo { ID = 4, ENimi = "Timo", SNImi = "Salmi", Pisteet = 28});
            henkilot.Add(new Henkilo { ID = 5, ENimi = "Simo", SNImi = "Niemi", Pisteet = 30});

            return View(henkilot); // Lähetetään henkilölista Viewiin. 
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