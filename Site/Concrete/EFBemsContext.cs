using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Site.DB;

namespace Site.Concrete
{
    public class EFBemsContext : DbContext
    {
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Report> Reports { get; set; }
    }
}