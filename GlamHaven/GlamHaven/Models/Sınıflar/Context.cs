using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GlamHaven.Models.Sınıflar
{
    public class Context : DbContext
    {
        public DbSet<Hizmetler> Hizmetlers{ get; set; }
        public DbSet<Hakkimizda> Hakkimizdas{ get; set; }
    }
}