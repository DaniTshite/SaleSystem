
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
    public class OrdersProcessor
    {
        
        public static string SaveSupplyOrder(Orders model)
        {
            //using (IDbConnection cn=new SqlConnection(SqlDataAccess.GetConnectionString()))
            //{
            //    cn.Open();
            //    using (var trans = cn.BeginTransaction())
            //    {
            //        try
            //        {

            //            trans.Commit();
            //        }
            //        catch(Exception ex)
            //        {
            //            trans.Rollback();
            //        }
            //    }
            //}
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
                OrderLineProcessor.SaveOrderLine(model);
                return "1 Record has been added Successfully ";
            }
            catch (Exception)
            {
                return "Something went wrong";
            }
                
        }
        //TO DO  check the list of order details is empty
        public static List<OrderLine> GetOrderDetails(string orderNumber)
        {
            var output = SqlDataAccess.LoadMultiData(orderNumber);
            return output;
        }
        public static List<Orders> GetFilteredOrdersByDate(DateTime inferiorDate, DateTime superiorDate)
        {
            var output = SqlDataAccess.FilterOrdersByDate(inferiorDate,superiorDate);
            return output;
        }

        public static List<OrderLine> GetItemsToReorder(List<Item> items)
        {
            SqlDataAccess.LoadLists();
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
            SqlDataAccess.LoadLists();
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

       
        public static bool IsStockQuantityEnough(int firstNumber,int secondNumber)
        {
             return (firstNumber > secondNumber) ? false : true;
        }
    }
}
