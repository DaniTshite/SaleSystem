using System;
using System.Collections.Generic;

namespace DataLibrary.Models
{
    public interface IQuotations
    {
        int QuotationId { get; set; }
        DateTime QuotationDate { get; set; }
        int QuotationNumber { get; set; }
        decimal SubTotal { get; set; }
        decimal Tax { get; set; }
        int Discount { get; set; }
        decimal Total { get; set; }
        Users SelectedUser { get; set; }
        CustomerAccount SelectedAccount { get; set; }
        List<IQuotationLine> QuotationDetails { get; set; }
    }
}