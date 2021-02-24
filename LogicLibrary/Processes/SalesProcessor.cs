using Dapper;
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
    public class SalesProcessor
    {
        private static readonly Random _random = new Random();

        // Generates a random number for the invoice.      
        public static int  GetInvoiceNumber()
        {
            return _random.Next (10000,9999999);
        }

        public static string SaveSaleOrder(Sales model)
        {
            
            using (IDbConnection cn = new SqlConnection(SqlDataAccess.GetConnectionString()))
            {
                cn.Open();
                using (var trans=cn.BeginTransaction())
                {
                    try
                    {
                        var data = new DynamicParameters();
                        data.Add("@InvoiceNumber", model.InvoiceNumber);
                        data.Add("@Discount", model.Discount);
                        data.Add("@SubTotal", model.SubTotal);
                        data.Add("@Tax", model.Tax);
                        data.Add("@Total", model.Total);
                        data.Add("@PaymentMode", model.PaymentMode);
                        data.Add("@DeliveryMode", model.DeliveryMode);
                        data.Add("@AccountId", 1);
                        data.Add("@QuotationId", 1);
                        data.Add("@UserId", 1);
                        data.Add("@SaleId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                        cn.Execute("spSales_insert", data,transaction:trans, commandType: CommandType.StoredProcedure);
                        model.SaleId = data.Get<int>("@SaleId");
                        SaleLineProcessor.SaveSaleLine(model);
                        trans.Commit();
                    }
                    catch (Exception)
                    {
                        trans.Rollback();
                        return "An Error Occured";
                    }
                }
                
                return "1 Record has been added Successfully ";
            }
            
        }
    }
}
