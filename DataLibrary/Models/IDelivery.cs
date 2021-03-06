using System;

namespace DataLibrary.Models
{
    public interface IDelivery
    {
        int DeliveryId { get; set; }
        int SaleId { get; set; }
        DateTime DeliveryDate { get; set; }
        string DeliveryType { get; set; }
    }
}