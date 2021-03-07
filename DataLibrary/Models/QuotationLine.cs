using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class QuotationLine : IQuotationLine
    {
        public Item SelectedItem { get; set; } = new Item();
        public Quotations Quotation { get; set; } = new Quotations();
        [DisplayName("QUANTITY")]
        public int QuotationQuantity { get; set; }
        [DisplayName("UNIT PRICE")]
        public decimal RetailPrice { get; set; }
        [DisplayName("NET TOTAL")]
        public decimal LineTotal { get; set; }
    }
}
