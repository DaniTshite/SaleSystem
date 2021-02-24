using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    /// <summary>
    /// This class an item object
    /// </summary>
    public class Item
    {
        [DisplayName("ITEM ID")]
        public int Itemid { get; set; }
        [DisplayName("STOCK CODE")]
        public string StockCode { get; set; }
        [DisplayName("BAR CODE")]
        public string barCode { get; set; }
        [DisplayName("DESCRIPTION")]
        public string Descript { get; set; }
        
        [DisplayName("VAT")]
        public int Vat { get; set; }
        [DisplayName("CATEGORY")]
        public int CategoryId { get; set; }
        [DisplayName("ACTIVE")]
        public int IsActive { get; set; }
        [DisplayName("REORDER LEVEL")]
        public int ReOrderlevel { get; set; }
        public int Profit { get; set; }
    }
}
