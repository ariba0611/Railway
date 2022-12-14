using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Railway.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public string Name { get; set;}
        public string Gender { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; } 
        public string From { get; set; }    

        public string To { get; set; }    

        public double Fare { get; set; }

        public IEnumerable<Reservation> ressss { get; set; }
    }
}