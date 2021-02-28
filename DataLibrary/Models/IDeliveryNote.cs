using System;

namespace DataLibrary.Models
{
    public interface IDeliveryNote
    {
        DateTime DeliveryDate { get; set; }
        int DeliveryId { get; set; }
        Sales ListInvoices { get; set; }
    }
}