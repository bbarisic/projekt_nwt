using NWT_AirBnb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NWT_AirBnb.DAL
{
    public class AirBnbInitializer : DropCreateDatabaseAlways<AirBnbContext>
    {
        protected override void Seed(AirBnbContext context)
        {
            var korisnici = new List<Korisnik>
            {
                new Korisnik() {Ime = "Marko", Prezime="Maric", Email = "marko@fesb.hr", Slika = "~/Images/london.jpg", Password="aaaa", Username="marko" },
                new Korisnik() {Ime = "Ana", Prezime = "Anic", Email = "ana@gmail.com", Slika= "~/Images/london.jpg", Password="aaaa", Username="marko" },
                new Korisnik() {Ime = "Pero", Prezime="Peric", Email = "pero@gmail.com", Slika="~/Images/london.jpg", Password="aaaa", Username="marko" }
            };
            korisnici.ForEach(korisnik => context.Korisniks.Add(korisnik));

            var smjestaj = new List<Smjestaj>
            {
                   new Smjestaj() {Naziv = "Sagrada Familia", Lokacija="Barcelona", Opis = "Katedrala", Ocjena = 5  },
                   new Smjestaj() {Naziv = "Wembley", Lokacija = "London", Opis = "Stadion", Ocjena = 5 }
            };
            smjestaj.ForEach(mjesto => context.Smjestaji.Add(mjesto));

            //context.SaveChanges();
            base.Seed(context);
        }
    }
}
