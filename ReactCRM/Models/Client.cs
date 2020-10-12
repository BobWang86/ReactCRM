using Bogus;
using System;
using System.Collections.Generic;

namespace ReactCRM.Models
{
    class Client : Faker<Client>
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Institute { get; set; }
        public string Source { get; set; }
        public string Pipeline { get; set; }
        public string AddDate { get; set; }
        public string ContactDate { get; set; }

        public List<string> SourceList = new List<string> { "Call", "Email", "Referal", "Partner", "Campaign", "WebForm", "SocialMedia" };

        public Client()
        {
            Faker faker = new Faker("en");
            DateTime newYear = new DateTime(2019, 01, 01);
            DateTime add = faker.Date.Between(newYear, DateTime.Today);
            DateTime contact = faker.Date.Soon(faker.Random.Number(1, 10), add);

            ID = 0;
            Name = faker.Name.FullName();
            Email = faker.Internet.Email(Name);
            Phone = faker.Phone.PhoneNumber();
            Institute = faker.Company.CompanyName();
            Source = faker.PickRandom(SourceList);
            Pipeline = "Awareness";
            AddDate = add.ToString("yyyy-MM-dd");
            ContactDate = contact.ToString("yyyy-MM-dd");
        }
    }
}
