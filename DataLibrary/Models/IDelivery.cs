using System;

namespace DataLibrary.Models
{
    public interface IDelivery
    {
        int DeliveryId { get; set; }
        int SaleId { get; set; }
        DateTime DeliveryDate { get; set; }
        DeliveryType deliveryType { get; set; }
        string DeliveryNumber { get; set; }
        int DeliveryStatus { get; set; }
    }
}