using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    /// <summary>
    /// this class represents a quotation of a sale order
    /// </summary>
    public class Quotations : IQuotations
    {
        public int QuotationId { get; set; }
        public DateTime QuotationDate { get; set; }
        public int Discount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public CustomerAccount Account { get; set; } = new CustomerAccount();
        public Users User { get; set; } = new Users();
    }
}
