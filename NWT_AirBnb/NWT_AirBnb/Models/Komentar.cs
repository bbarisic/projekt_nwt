using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NWT_AirBnb.Models
{
    public class Komentar
    {
        public int ID { get; set; }

        [Required]
        public string Objava { get; set; }

        public Smjestaj Smjestaj { get; set; }
    }
}