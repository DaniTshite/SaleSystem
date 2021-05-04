using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    /// <summary>
    /// This class represents a delivery note of a sale order
    /// </summary>
    public class Delivery : IDelivery
    {
        [DisplayName("ID")]
        public int DeliveryId { get; set; }
        [DisplayName("INVOICE ID")]
        public int SaleId { get; set; }
        [DisplayName("DELIVERY DATE")]
        public DateTime DeliveryDate { get; set; }
        [DisplayName("DELIVERY TYPE")]
        public DeliveryType deliveryType { get; set; }
        [DisplayName("DELIVERY No")]
        public string DeliveryNumber { get; set; }
        [DisplayName("STATUS")]
        public int DeliveryStatus { get; set; }
    }
}
