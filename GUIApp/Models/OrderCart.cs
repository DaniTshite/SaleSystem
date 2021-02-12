using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIApp.Models
{
    public class OrderCart : IOrder
    {

        [DisplayName("No")]
        public int Id { get; set; }
        [DisplayName("DESCRIPTION")]
        public string Descript { get; set; }
        [DisplayName("STOCK CODE")]
        public string StockCode { get; set; }

        [DisplayName("QUANTITY")]
        public int PurchasedQuantity { get; set; }
        [DisplayName("UNIT PRICE")]
        public decimal PurchasePrice { get; set; }
        [DisplayName("NET TOTAL")]
        public decimal LineTotal { get; set; }


    }
}
