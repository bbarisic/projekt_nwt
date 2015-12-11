using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT_AirBnb.Models
{
    public class Iznajmljivac : Korisnik
    {
        public virtual List<Smjestaj> Smjestaj { get; set; }
    }
}