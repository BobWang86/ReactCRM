using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCRM.Models
{
    class Sale : Faker<Sale>
    {
        //SaleID`, `Client`, `Product`, `Price`, `Date
        //Interactive Timetabling", "Automated Timetabling", "Attendance Monitoring", "Room Booking", 
        //"Pay Claim", "Integration", "Consultancy", "Training"

        public int ID { get; set; }
        public int ClientID { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
