using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIApp.Models
{
    public class ItemsReport :IOrder
    {
        [DisplayName("No")]
        public int Id { get ; set ; }
        [DisplayName("DESCRIPTION")]
        public string Descript { get; set; }
        [DisplayName("STOCK CODE")]
        public string StockCode { get ; set ; }
        [DisplayName("QUANTITY")]
        public int PurchasedQuantity { get ; set ; }
        [DisplayName("REORDER LEVEL")]
        public int ReOrderLevel { get; set; }
    }
}
