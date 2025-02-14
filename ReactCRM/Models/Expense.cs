﻿using Bogus;
using System;
using System.Collections.Generic;

namespace ReactCRM.Models
{
    class Expense : Faker<Expense>
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public string Date { get; set; }

        public List<string> TypeList = new List<string> { "Employee salaries", "Office Expenses", "Vehicles Expenses", "Equipment Expenses", "Maintenance Expenses", "Business Insurances", "Consultancy Fees", "Marketing Costs", "Miscellaneous Expenses" };

        public Expense()
        {
            Faker faker = new Faker("en");
            DateTime newYear = new DateTime(2019, 01, 01);
            DateTime expenseDate = faker.Date.Between(newYear, DateTime.Today);

            ID = 0;
            Type = faker.PickRandom(TypeList);
            Amount = Math.Round(faker.Random.Decimal(300, 3000), 0);
            Date = expenseDate.ToString("yyyy-MM-dd");
        }
    }
}
