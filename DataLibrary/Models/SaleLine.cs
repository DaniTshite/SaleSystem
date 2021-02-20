using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class SaleLine
    {
        public Item SelectedItem { get; set; }
        public  Sales Sale { get; set; }
        [DisplayName("QUANTITY")]
        public int SaleQuantity { get; set; }
        [DisplayName("UNIT PRICE")]
        public decimal RetailPrice { get; set; }
        [DisplayName("NET TOTAL")]
        public decimal LineTotal { get; set; }
    }
}
