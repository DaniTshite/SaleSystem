using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    /// <summary>
    /// This class represents a customer account
    /// </summary>
    public class CustomerAccount : ICustomerAccount
    {
        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public string CellPhone { get; set; }
        public string EmailAddress { get; set; }
        public string PhysicalAddress { get; set; }

    }
}
