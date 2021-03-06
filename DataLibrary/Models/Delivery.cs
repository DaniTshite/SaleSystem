using System;
using System.Collections.Generic;
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
        public int DeliveryId { get; set; }
        public int SaleId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryType { get; set; } 
    }
}
