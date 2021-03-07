using System;
using System.Collections.Generic;

namespace DataLibrary.Models
{
    public interface IOrders
    {
        DateTime OrderDate { get; set; }
        string OrderNumber { get; set; }
        Supplier SelectedSupplier { get; set; }
        decimal SubTotal { get; set; }
        List<IOrderLine> SupplyOrderDetails { get; set; }
        decimal Tax { get; set; }
        decimal Total { get; set; }
    }
}