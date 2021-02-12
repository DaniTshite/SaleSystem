using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Quotations
    {
        public int QuotationId { get; set; }
        public DateTime QuotationDate { get; set; }
        public int Discount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public int Accountid { get; set; }
        public int Userid { get; set; }
    }
}
