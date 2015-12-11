using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NWT_AirBnb.Models
{
    public class Slike
    {
        public int ID { get; set; }

        public string Slika { get; set; }

        public Smjestaj Smjestaj { get; set; }
    }
}