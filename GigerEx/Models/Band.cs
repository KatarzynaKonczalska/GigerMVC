using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GigerEx.Models
{
    public class Band
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
    }

    public class BandDBContext : DbContext
    {
        public DbSet<Band> Bands { get; set; }
    }
}