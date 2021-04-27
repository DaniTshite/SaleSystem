using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    /// <summary>
    /// This class represents a sale order
    /// </summary>
    public class Sales : ISales
    {
        public int SaleId { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public int Discount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public string PaymentMode { get; set; }
        public int  DeliveryMode { get; set; }
        public List<SaleLine> SaleOrderDetails { get; set; }
        public CustomerAccount SelectedAccount { get; set; } = new CustomerAccount();
        public Quotations SelectedQuotation { get; set; } = new Quotations();
        public Users SelectedUser { get; set; } = new Users();

    }
}
