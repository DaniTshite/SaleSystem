using Dapper;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public class SqlDataAccess
    {
        public static List<Item> loadedItems { set; get; } = null;
        public static List<Supplier> loadedSuppliers { set; get; } = null;
        public static List<Category> loadedCategories { set; get; } = null;
        public static List<Users> loadedUsers { set; get; } = null;
        public static List<Quotations> loadedQuotations { set; get; } = null;
        public static List<CustomerAccount> loadedCustomerAccounts { set; get; } = null;
        public static string GetConnectionString(string name = "AspDb")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cn = new SqlConnection(GetConnectionString()))
            {
                var output = cn.Query<T>(sql).ToList();
                return output;
            }
        }
        public static List<Orders> FilterOrdersByDate(DateTime inferiorDate,DateTime superiorDate)
        {
            
            using (IDbConnection cn = new SqlConnection(GetConnectionString()))
            {
                var p = new
                {
                    InferiorDate = inferiorDate,
                    SuperiorDate = superiorDate
                };
                
                string sql = @"spOrders_FilterByDate @InferiorDate,@SuperiorDate";
                var query = cn.Query<Orders, Supplier, Orders>(sql,
                         (O, S) =>
                         {
                             O.SelectedSupplier = S;
                             return O;
                         },
                         p,
                         splitOn: "SupplierId").AsQueryable();

                return query.ToList();
            }
           
        }
        public static List<OrderLine> LoadEntryQuantities()
        {
            using (IDbConnection cn = new SqlConnection(GetConnectionString()))
            {
                string sql = @"spOrderLine_GetEntryQuantityByItem";
                var query = cn.Query<Item, OrderLine, OrderLine>(sql,
                         (I, OL) =>
                         {
                                OL.SelectedItem = I;
                                return OL;
                         },
                         splitOn: "PurchasedQuantity").AsQueryable();

                return query.ToList();
            }
        }
        
        public static List<SaleLine> LoadSoldQuantities()
        {
            using (IDbConnection cn = new SqlConnection(GetConnectionString()))
            {
                string sql = @"spSaleLine_GetSoldQuantityByItem";
                var query = cn.Query<Item, SaleLine, SaleLine>(sql,
                         (I, SL) =>
                         {
                             SL.SelectedItem = I;
                             return SL;
                         },
                         splitOn: "SaleQuantity").AsQueryable();

                return query.ToList();
            }
        }
        public static List<OrderLine> LoadOrderData(string orderNumber)
        {
            using (IDbConnection cn = new SqlConnection(GetConnectionString()))
            {
                var p = new
                {
                    OrderNumber = orderNumber
                };
                string sql = @"spOrders_GetAllByOrderNumber @OrderNumber";
                var query = cn.Query<Item, Orders, Supplier, OrderLine, OrderLine>(sql,
                   (I, O, S, OL) =>
                                 {
                                     OL.SelectedItem = I;
                                     OL.Order = O;
                                     OL.Order.SelectedSupplier = S;
                                     return OL;
                                 },
                                 p,
                                 splitOn: "OrderNumber,SupplierId,PurchasedQuantity").AsQueryable();

                return query.ToList();
            }
        }

        public static List<SaleLine> LoadSaleData(string invoiceNumber)
        {
            using (IDbConnection cn = new SqlConnection(GetConnectionString()))
            {
                var p = new
                {
                    InvoiceNumber = invoiceNumber
                };
                string sql = @"spSales_GetAllByInvoiceNumber @InvoiceNumber";
                var query = cn.Query<Item, SaleLine, Sales, Users, Quotations,CustomerAccount,SaleLine>(sql,
                   (I, SL, S, U,Q,CA) =>
                   {
                       SL.SelectedItem = I;
                       SL.Sale = S;
                       SL.Sale.SelectedUser = U;
                       SL.Sale.SelectedQuotation = Q;
                       SL.Sale.SelectedAccount = CA;
                       return SL;
                   },
                                 p,
                                 splitOn: "ItemId,SaleId,UserId,QuotationId,AccountId").AsQueryable();

                return query.ToList();
            }
        }
        public static int RegisterData<T>(string sql, T Data)
        {
            using (IDbConnection cn = new SqlConnection(GetConnectionString()))
            {
                return cn.Execute(sql, Data);
            }
        }
        //constructor
        
        public static void LoadLists()
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                //string sql = @"spAlltables_GetAll";

                //using (var lists = cnn.QueryMultiple(sql))
                //{
                //    loadedItems = lists.Read<Item>().ToList();
                //    loadedSuppliers = lists.Read<Supplier>().ToList();
                //    loadedCategories = lists.Read<Category>().ToList();
                //    loadedUsers = lists.Read<Users>().ToList();
                //    loadedQuotations= lists.Read<Quotations>().ToList();
                //    loadedCustomerAccounts = lists.Read<CustomerAccount>().ToList();
                //}

            }

        }

    }
}
