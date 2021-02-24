using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    /// <summary>
    /// This class represents a line on a supply order
    /// </summary>
    public class OrderLine
    {
        public Item SelectedItem { get; set; } = new Item();
        public Orders Order { get; set; } = new Orders();
        [DisplayName("QUANTITY")]
        public int PurchasedQuantity { get; set; }
        [DisplayName("UNIT PRICE")]
        public decimal PurchasePrice { get; set; }
        [DisplayName("NET TOTAL")]
        public decimal LineTotal { get; set; }
    }
}
