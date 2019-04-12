using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactCRM.Models
{
    class Client : Faker<Client>
    {
        //`ClientID`, `Name`, `Email`, `Phone`, `Institute`, `Source`, `Pipeline`, `AddDate`, `ContactDate`
        //"Call", "Email", "Referal", "Partner", "Campaign", "WebForm", "SocialMedia"
        //"Awareness", "Interest", "Decision", "Action"
        public int ID { get; set; }
        public string Name{ get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Institute { get; set; }
        public string Source { get; set; }
        public string Pipeline { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime ContactDate { get; set; }
    }
}
