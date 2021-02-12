using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class Sales
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public int Discount { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public string PaymentMode { get; set; }
        public string DeliveryMode { get; set; }
        public int AccountId { get; set; }
        public int QuotationId { get; set; }
        public int UserId { get; set; }
    }
}
