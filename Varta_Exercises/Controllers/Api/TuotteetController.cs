using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Ajax.Utilities;
using Varta_Exercises.Models;

namespace Varta_Exercises.Controllers
{
    public class TuotteetController : ApiController
    {
        private TuoteDBContext _tuoteDb;

        public TuotteetController()
        {

        _tuoteDb = new TuoteDBContext();

        }

        // GET pyyntö tuotelistalle querystringin perusteella /api/tuottee?nimi=<hakusana>
        public IEnumerable<Tuote> GetTuotteet(string nimi)
        {

            var nimi1 = nimi;

            //if (nimi1.IsNullOrWhiteSpace())
            //{
            //    return _tuoteDb.Tuotteet.ToList();
            //}
            //else
            //{
                var haetutTuotteet = _tuoteDb.Tuotteet.Where(t => t.Nimi.Contains(nimi)).ToList();
                return haetutTuotteet;
            //}

        }

        // GET pyyntö hinnalle /api/tuotteet?alaraja=<arvo>&ylaraja=<arvo> 
        public IEnumerable<Tuote> GetTuotteet(int alaraja, int ylaraja)
        {

 
                var haetutTuotteet = _tuoteDb.Tuotteet.Where(t => t.Hinta <= ylaraja && t.Hinta >= alaraja).ToList();
                return haetutTuotteet;
            

        }
        // Get pyyntö tuotelistalle /api/tuotteet joka palauttaa koko listan tuotteista
        public IEnumerable<Tuote> GetTuotteet()
        {

           
        return _tuoteDb.Tuotteet.ToList();
           
        }

        // GET pyyntö tietyn tuotenumeron tuotteelle /Api/Tuotteet/1

        public Tuote GetTuote(int id)
        {
            var haettutuote = _tuoteDb.Tuotteet.SingleOrDefault(t => t.Tuotenumero == id);

            if(haettutuote == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return haettutuote;
        }


       
     
        


    }
}
