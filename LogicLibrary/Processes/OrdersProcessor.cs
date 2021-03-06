
using DataLibrary.Data;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{
    /// <summary>
    /// This class contains processes relating to orders
    /// </summary>
    public class OrdersProcessor : IOrdersProcessor
    {
        OrderLineProcessor _orderLineProcessor = new OrderLineProcessor();
        /// <summary>
        /// This method saves data into the DB
        /// </summary>
        /// <param name="model">This is an Orders object </param>
        /// <returns>It returns a string </returns>
        public string SaveSupplyOrder(Orders model)
        {
            try
            {
                var data = new
                {
                    OrderNumber = model.OrderNumber,
                    OrderDate = model.OrderDate,
                    SubTotal = model.SubTotal,
                    Tax = model.Tax,
                    Total = model.Total,
                    SupplierId = model.SelectedSupplier.SupplierId,
                    Details = model.SupplyOrderDetails
                };
                string sql = @"spOrders_insert @OrderNumber,@OrderDate,@SubTotal,@Tax,@Total,@SupplierId";
                SqlDataAccess.RegisterData(sql, data);
                _orderLineProcessor.SaveOrderLine(model);
                return "1 Record has been added Successfully ";
            }
            catch (Exception)
            {
                return "Something went wrong";
            }
        }
        /// <summary>
        /// This method gets details relating to a supply order
        /// </summary>
        /// <param name="orderNumber">This is a string parameter </param>
        /// <returns>It returns a list of Orderline objects </returns>
        public List<OrderLine> GetOrderDetails(string orderNumber)
        {
            var output = SqlDataAccess.LoadOrderData(orderNumber);
            return output;
        }
        /// <summary>
        /// This method filters orders elonging to a given period
        /// </summary>
        /// <param name="inferiorDate">This is the first date</param>
        /// <param name="superiorDate">This is the second date</param>
        /// <returns>It returns a list of orders objects</returns>
        public static List<Orders> GetFilteredOrdersByDate(DateTime inferiorDate, DateTime superiorDate)
        {
            var output = SqlDataAccess.FilterOrdersByDate(inferiorDate, superiorDate);
            return output;
        }
        /// <summary>
        /// This method gets items to reorder
        /// </summary>
        /// <param name="items">This a list of item objects</param>
        /// <returns>It returns a list of orderline objects </returns>
        public List<OrderLine> GetItemsToReorder(List<Item> items)
        {
            SqlDataAccess.LoadLists();
            List<OrderLine> ItemsToOrder = new List<OrderLine>();
            var listItemQuantities = _orderLineProcessor.GetEntryQuantityByItem();
            foreach (var itemQuantity in listItemQuantities)
            {
                foreach (var i in items)
                {
                    if ((itemQuantity.SelectedItem.Itemid == i.Itemid) && (itemQuantity.PurchasedQuantity < i.ReOrderlevel) && (i.IsActive == 1))
                    {
                        OrderLine r = new OrderLine
                        {
                            SelectedItem = new Item
                            {
                                StockCode = i.StockCode,
                                Descript = i.Descript,
                                ReOrderlevel = i.ReOrderlevel
                            },
                            PurchasedQuantity = itemQuantity.PurchasedQuantity,
                        };
                        ItemsToOrder.Add(r);
                    }
                }
            }
            return ItemsToOrder;
        }
        /// <summary>
        /// This method gets inactive items 
        /// </summary>
        /// <param name="items">This a list of item objects</param>
        /// <returns>It returns a list of orderline objects </returns>
        public List<OrderLine> GetInactiveItems(List<Item> items)
        {
            SqlDataAccess.LoadLists();
            List<OrderLine> ItemsToOrder = new List<OrderLine>();
            var listItemQuantities = _orderLineProcessor.GetEntryQuantityByItem();

            foreach (var itemQuantity in listItemQuantities)
            {
                foreach (var i in items)
                {
                    if ((itemQuantity.SelectedItem.Itemid == i.Itemid) && (i.IsActive == 0))
                    {
                        OrderLine o = new OrderLine
                        {
                            SelectedItem = new Item
                            {
                                StockCode = i.StockCode,
                                Descript = i.Descript,
                                ReOrderlevel = i.ReOrderlevel
                            },
                            PurchasedQuantity = itemQuantity.PurchasedQuantity,
                        };
                        ItemsToOrder.Add(o);
                    }
                }
            }
            return ItemsToOrder;
        }
        
    }
}
