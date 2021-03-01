using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DisplayName("No")]
        public int AccountId { get; set; }
        [DisplayName("FIRSTNAME")]
        public string FirstName { get; set; }
        [DisplayName("LASTNAME")]
        public string LastName { get; set; }
        [DisplayName("ID NUMBER")]
        public string IdNumber { get; set; }
        [DisplayName("CELLPHONE")]
        public string CellPhone { get; set; }
        [DisplayName("EMAIL")]
        public string EmailAddress { get; set; }
        [DisplayName("ADDRESS")]
        public string PhysicalAddress { get; set; }
        [DisplayName("GENDER")]
        public string Gender { get; set; }
        public string FullName
        {
            get { return $"{FirstName}  {LastName}"; }
        }

    }
}
