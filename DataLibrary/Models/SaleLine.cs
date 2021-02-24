using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    /// <summary>
    /// This class represents a line on a sale order
    /// </summary>
    public class SaleLine
    {
        public Item SelectedItem { get; set; } = new Item();
        public Sales Sale { get; set; } = new Sales();
        [DisplayName("QUANTITY")]
        public int SaleQuantity { get; set; }
        [DisplayName("UNIT PRICE")]
        public decimal RetailPrice { get; set; }
        [DisplayName("NET TOTAL")]
        public decimal LineTotal { get; set; }
    }
}
