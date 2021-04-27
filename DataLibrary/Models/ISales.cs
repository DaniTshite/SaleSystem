using System;
using System.Collections.Generic;

namespace DataLibrary.Models
{
    public interface ISales
    {
        int DeliveryMode { get; set; }
        int SaleId { get; set; }
        DateTime SaleDate { get; set; }
        int Discount { get; set; }
        int InvoiceNumber { get; set; }
        string PaymentMode { get; set; }
        List<SaleLine> SaleOrderDetails { get; set; }
        CustomerAccount SelectedAccount { get; set; }
        Quotations SelectedQuotation { get; set; }
        Users SelectedUser { get; set; }
        decimal SubTotal { get; set; }
        decimal Tax { get; set; }
        decimal Total { get; set; }
    }
}