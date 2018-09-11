using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Varta_Exercises.Models
{
    public class Tuote
    {
        [Key]
        public int Tuotenumero { get; set; }
        public string Kategoria { get; set; }
        [Required]
        public string Nimi { get; set; }
        public decimal Hinta { get; set; }
        public string Kuvaus { get; set; }
        public DateTime Muokattu { get; set; }


    }

    public class TuoteDBContext : DbContext
    {
        public DbSet<Tuote> Tuotteet { get; set; }


    }






}