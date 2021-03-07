
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    /// <summary>
    /// This class represents a supply order
    /// </summary>
    public class Orders : IOrders
    {
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public Supplier SelectedSupplier { get; set; }
        public List<IOrderLine> SupplyOrderDetails { get; set; } = new List<IOrderLine>();

    }
}
