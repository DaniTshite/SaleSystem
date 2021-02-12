
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
    public class OrderProcessor
    {
        //public static string GenerateOrderNumber()
        //{
        //    Random random = new Random();
        //    int orderNumber = random.Next(10000000);
        //    return "ORD" + orderNumber.ToString();
        //}
        public static void SaveOrder(Orders model)
        {
             var data = new 
            {
                OrderNumber = model.OrderNumber,
                OrderDate = model.OrderDate,
                SubTotal = model.SubTotal,
                Tax = model.Tax,
                Total = model.Total,
                SupplierId = model.SelectedSupplier.SupplierId,
                Details = model.Details
            };
            string sql = @"spOrders_insert @OrderNumber,@OrderDate,@SubTotal,@Tax,@Total,@SupplierId";
            SqlDataAccess.RegisterData(sql, data);
            OrderLineProcessor.SaveOrderLine(model);
        }

        public static List<OrderLine> GetOrderDetails(string orderNumber)
        {
            var output = SqlDataAccess.LoadMultiData(orderNumber);
            return output;
        }

        public static List<OrderLine> GetItemsToReorder(List<Item> items)
        {
            SqlDataAccess.MultipleSets();
            List<OrderLine> ItemsToOrder = new List<OrderLine>();
            var listItemQuantities = OrderLineProcessor.GetEntryQuantityByItem();
            foreach (var itemQuantity in listItemQuantities)
            {
                foreach (var i in items)
                {
                    if ((itemQuantity.SelectedItem.Itemid == i.Itemid) && (itemQuantity.PurchasedQuantity < i.ReOrderlevel) &&(i.IsActive==1))
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

        public static List<OrderLine> GetInactiveItems(List<Item> items)
        {
            SqlDataAccess.MultipleSets();
            List<OrderLine> ItemsToOrder = new List<OrderLine>();
            var listItemQuantities = OrderLineProcessor.GetEntryQuantityByItem();
            
            foreach (var itemQuantity in listItemQuantities)
            {
                foreach (var i in items)
                {
                    if ((itemQuantity.SelectedItem.Itemid == i.Itemid) && (i.IsActive == 0))
                    {
                        OrderLine o = new OrderLine
                        {
                            SelectedItem=new Item 
                            {
                                StockCode=i.StockCode,
                                Descript=i.Descript,
                                ReOrderlevel=i.ReOrderlevel
                            },
                            PurchasedQuantity = itemQuantity.PurchasedQuantity,
                        };
                        ItemsToOrder.Add(o);
                    }
                }
            }
            return ItemsToOrder;
        }

        //public static List<OrderLineCart> GetCombinedItems(List<Item> items)
        //{
        //    SqlDataAccess.MultipleSets();
        //    List<OrderLineCart> CombinedItems = new List<OrderLineCart>();
        //    var listItemQuantities = OrderLineProcessor.GetEntryQuantityByItem();
        //    int counter = 1;
        //    foreach (var itemQuantity in listItemQuantities)
        //    {
        //        foreach (var i in items)
        //        {
        //            if ((itemQuantity.ItemId == i.Itemid) &&(i.IsActive == 1))
        //            {
        //                OrderLineCart r = new OrderLineCart
        //                {
        //                    Id = counter,
        //                    StockCode = i.StockCode,
        //                    Descript = i.Descript,
        //                    PurchasedQuantity = itemQuantity.PurchasedQuantity,
        //                    ReOrderLevel = i.ReOrderlevel,
        //                    ItemId=i.Itemid
        //                };
        //                CombinedItems.Add(r);
        //                counter += 1;
        //            }
        //        }
        //    }
        //    return CombinedItems;
        //}
        public static bool IsStockQuantityEnough(int firstNumber,int secondNumber)
        {
             return (firstNumber > secondNumber) ? false : true;
        }
    }
}
