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
        public int ClientID { get; set; }
        public string Detail { get; set; }
        public string TicType { get; set; }
        public string TicStatus { get; set; }
        public string ReportDate { get; set; }
        public string RespondDate { get; set; }

        //List<string> TypeList = new List<string> { "Order Status", "Bug Report", "Feature Request", "Technical Support" };
        //List<string> StatusList = new List<string> { "Pending", "Responding", "Unsolved", "Solved" };

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
            DateTime start = new DateTime(2019, 01, 01);

            ID = 0;
            ClientID = faker.Random.Number(1, clientCount);
            Detail = faker.Lorem.Sentence(faker.Random.Number(25, 50));
            TicType = faker.PickRandom<TypeList>().ToString();
            TicStatus = faker.PickRandom<StatusList>().ToString();
            ReportDate = faker.Date.Between(start, DateTime.Today).ToString("yyyy-MM-dd");
            RespondDate = null;

            //RuleFor(o => o.ID, f => f.Random.Number(1, 100));
            //RuleFor(o => o.ClientID, f => f.Random.Number(1, 100));
            //RuleFor(o => o.Detail, f => f.Lorem.Sentence());
            //RuleFor(o => o.TicType, f => f.PickRandom<TypeList>());
            //RuleFor(o => o.TicStatus, f => f.PickRandom<StatusList>());
            //RuleFor(o => o.ReportDate, f => f.Random.Number(1, 10));
            //RuleFor(o => o.RespondDate, f => f.Random.Number(1, 10));
        }
    }
}
