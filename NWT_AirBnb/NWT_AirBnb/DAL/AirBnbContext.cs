using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NWT_AirBnb.Models;

namespace NWT_AirBnb.DAL
{
    public class AirBnbContext:DbContext
    {
        public DbSet<Korisnik> Korisniks { get; set; }
        public DbSet<Iznajmljivac> Iznajmljivaci { get; set; }
        public DbSet<Slike> Slike { get; set; }
        public DbSet<Komentar> Komentari { get; set; }
        public DbSet<Smjestaj> Smjestaji { get; set; }
    }
}