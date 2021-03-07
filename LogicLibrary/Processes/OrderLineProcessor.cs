using DataLibrary.Data;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{
    /// <summary>
    /// This class contains processes relating to orderline
    /// </summary>
    public class OrderLineProcessor : IOrderLineProcessor
    {
        /// <summary>
        /// This method saves an orderline object into the DB
        /// </summary>
        /// <param name="order">This is an order object</param>
        public void SaveOrderLine(IOrders order)
        {
            foreach (var item in order.SupplyOrderDetails)
            {
                var data = new
                {
                    OrderNumber = order.OrderNumber,
                    Order = order,
                    ItemId = item.SelectedItem.Itemid,
                    PurchasedQuantity = item.PurchasedQuantity,
                    PurchasePrice = item.PurchasePrice,
                    LineTotal = item.LineTotal
                };
                string sql = @"spOrderLine_insert @OrderNumber,@ItemId,@PurchasedQuantity,@PurchasePrice,@LineTotal";
                SqlDataAccess.RegisterData(sql, data);
            }
        }
        /// <summary>
        /// This method gets the total entry quantities by item
        /// </summary>
        /// <returns>It rreturns a list of orderline objects</returns>
        public List<OrderLine> GetEntryQuantityByItem()
        {
            var output = SqlDataAccess.LoadEntryQuantities();
            return output;
        }
    }
}
