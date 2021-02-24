using DataLibrary.Data;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{
    public class OrderLineProcessor
    {
        public static void SaveOrderLine(Orders order)
        {
            foreach (var item in order.SupplyOrderDetails)
            {
                var data = new 
                {
                    OrderNumber=order.OrderNumber,
                    Order=order,
                    ItemId=item.SelectedItem.Itemid,
                    PurchasedQuantity=item.PurchasedQuantity,
                    PurchasePrice=item.PurchasePrice,
                    LineTotal=item.LineTotal
                };
                string sql = @"spOrderLine_insert @OrderNumber,@ItemId,@PurchasedQuantity,@PurchasePrice,@LineTotal";
                SqlDataAccess.RegisterData(sql, data);
            }
        }

        public static List<OrderLine> GetEntryQuantityByItem()
        {
            var output= SqlDataAccess.LoadEntryQuantities();
            return output;
        }
    }
}
