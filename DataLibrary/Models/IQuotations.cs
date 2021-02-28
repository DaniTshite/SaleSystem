using System;

namespace DataLibrary.Models
{
    public interface IQuotations
    {
        CustomerAccount Account { get; set; }
        int Discount { get; set; }
        DateTime QuotationDate { get; set; }
        int QuotationId { get; set; }
        decimal SubTotal { get; set; }
        decimal Tax { get; set; }
        decimal Total { get; set; }
        Users User { get; set; }
    }
}