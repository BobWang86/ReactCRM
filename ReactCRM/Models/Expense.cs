using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCRM.Models
{
    class Expense : Faker<Expense>
    {
        //`ExpenseID`, `Type`, `Amount`, `Date`
        // "Employee salaries", "Office Expenses", "Vehicles Expenses", "Equipment Expenses", 
        // "Maintenance Expenses", "Business Insurances", "Consultancy Fees", "Marketing Costs", "Miscellaneous Expenses"
        public int ID { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
