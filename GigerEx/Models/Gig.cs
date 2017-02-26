using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace GigerEx.Models
{
    public class Gig
    {
        public int ID { get; set; }

        public string Band { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Place { get; set; }

        public string Info { get; set; }

        [Display(Name ="Data")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd.MM.yy hh.mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        public DateTime Date { get; set; }
    }

    public class GigDBContext : DbContext
    {
        public GigDBContext()
            : base("GigerConnection")
        {

        } 
        public DbSet<Gig> Gigs { get; set; }
    }
}