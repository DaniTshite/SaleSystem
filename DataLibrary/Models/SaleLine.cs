using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class SaleLine
    {
        public int ItemId { get; set; }
        public int SaleId { get; set; }
        public int SaleQuantity { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal LineTotal { get; set; }
    }
}
