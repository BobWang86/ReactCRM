using Bogus;
using System;
using System.Collections.Generic;

namespace ReactCRM.Models
{
    class Sale : Faker<Sale>
    {
        public int ID { get; set; }
        public string ClientID { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public string Date { get; set; }

        public List<string> ProductList = new List<string>() { "Interactive Timetabling", "Automated Timetabling", "Attendance Monitoring", "Room Booking", "Pay Claim", "Integration", "Consultancy", "Training" };


        public Sale(int clientCount)
        {
            Faker faker = new Faker("en");
            DateTime newYear = new DateTime(2019, 01, 01);
            DateTime saleDate = faker.Date.Between(newYear, DateTime.Today);

            ID = 0;
            ClientID = faker.Random.Number(1, clientCount).ToString();
            Product = faker.PickRandom(ProductList);
            Price = Math.Round(faker.Random.Decimal(500, 5000), 0);
            Date = saleDate.ToString("yyyy-MM-dd");
        }
    }
}
