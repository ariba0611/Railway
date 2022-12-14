using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Railway.Models
{
    public class DataContext : DbContext
    {
       public DbSet<Reservation> Reservations { get; set; }

        public System.Data.Entity.DbSet<Railwa.Models.TrainDetails> TrainDetails { get; set; }
        // public DbSet<Reservation> reservations { get; set; }
    }
}




