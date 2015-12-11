using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWT_AirBnb.Models
{
    public class Smjestaj
    {
        public int SmjestajID { get; set; }

        [Required]
        public string Naziv { get; set; }

        [Required]
        public string Opis { get; set; }

        [Required]
        public string Lokacija { get; set; }

        public int Ocjena { get; set; }

        public Iznajmljivac Iznajmljivac { get; set; }
        public virtual List<Komentar> Komentar { get; set; }
        public virtual List<Slike> Slike { get; set; }
    }
}