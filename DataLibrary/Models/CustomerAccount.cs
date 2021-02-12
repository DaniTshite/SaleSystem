using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class CustomerAccount
    {
        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string idNumber { get; set; }
        public string Cellphone { get; set; }
        public string EmailAddress { get; set; }
        public string PhysicalAddress { get; set; }

    }
}
