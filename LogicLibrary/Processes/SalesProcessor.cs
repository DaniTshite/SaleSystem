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
    /// <summary>
    /// This class contains processes related to sale orders
    /// </summary>
    public class SalesProcessor
    {
        private static readonly Random _random = new Random();
        private static bool _doesInvoiceNumberExist = false;
        /// <summary>
        /// This method generate a random number for the invoice
        /// </summary>
        /// <returns>It returns an integer</returns>
        private static int  GenerateNumber()
        {
            return _random.Next(10000, 9999999);
        }
        /// <summary>
        /// This method validate the invoice number
        /// </summary>
        /// <returns>it returns an integer</returns>
        public static int GetInvoiceNumber()
        {
            int number = GenerateNumber();
            List<SaleLine> listSales = GetSaleDetails(number.ToString());
            while (!_doesInvoiceNumberExist)
            {
                if (listSales != null || listSales.Count > 0)
                {
                    _doesInvoiceNumberExist = true;
                }
                else
                {
                    number = GenerateNumber();
                }
            }
            return number;
        }
        
        /// <summary>
        /// This method save a sale order object into the DB 
        /// </summary>
        /// <param name="model"></param>
        /// <returns>It returns a message showing if the operation failed or succeeded</returns>
        public static string SaveSaleOrder(Sales model)
        {
            using (IDbConnection cn = new SqlConnection(SqlDataAccess.GetConnectionString()))
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
                    cn.Execute("spSales_insert", data, commandType: CommandType.StoredProcedure);
                    model.SaleId = data.Get<int>("@SaleId");
                    SaleLineProcessor.SaveSaleLine(model);
                    return "1 Record has been added Successfully ";
                }
                catch (Exception)
                {
                    return "An Error Occured";
                }
            }
        }
        /// <summary>
        /// This method get sale order details from the DB
        /// </summary>
        /// <param name="invoiceNumber">This is a string representing the invoice number </param>
        /// <returns>It returns a list of saleline objects </returns>
        public static List<SaleLine> GetSaleDetails(string invoiceNumber)
        {
            var output = SqlDataAccess.LoadSaleData(invoiceNumber);
            return output;
        }
    }
}
