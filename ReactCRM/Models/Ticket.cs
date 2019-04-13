using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCRM.Models
{
    class Ticket : Faker<Ticket>
    {
        public int ID { get; set; }
        public string ClientID { get; set; }
        public string Detail { get; set; }
        public string TicType { get; set; }
        public string TicStatus { get; set; }
        public string ReportDate { get; set; }
        public string RespondDate { get; set; }

        public enum TypeList
        {
            Order_Status,
            Bug_Report,
            Feature_Request,
            Technical_Support
        }

        public enum StatusList
        {
            Pending,
            Responding,
            Unsolved,
            Solved
        }

        public Ticket(int clientCount)
        {
            var faker = new Faker("en");
            DateTime newYear = new DateTime(2019, 01, 01);
            DateTime report = faker.Date.Between(newYear, DateTime.Today);
            DateTime response = faker.Date.Soon(faker.Random.Number(1, 10), report);

            ID = 0;
            ClientID = faker.Random.Number(1, clientCount).ToString();
            Detail = faker.Lorem.Sentence(faker.Random.Number(25, 50));
            TicType = faker.PickRandom<TypeList>().ToString();
            TicStatus = faker.PickRandom<StatusList>().ToString();
            ReportDate = report.ToString("yyyy-MM-dd");
            RespondDate = response.ToString("yyyy-MM-dd");
        }
    }
}
