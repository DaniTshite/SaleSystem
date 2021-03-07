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
    public class SalesProcessor : ISalesProcessor
    {
        readonly IDeliveryProcessor _deliveryProcessor = ContainerConfig.CreateDeliveryProcessor();
        readonly ISaleLineProcessor _saleLineProcessor = ContainerConfig.CreateSaleLineProcessor();
        private readonly Random _random = new Random();
        private bool _doesInvoiceNumberExist = false;
        /// <summary>
        /// This method generate a random number for the invoice
        /// </summary>
        /// <returns>It returns an integer</returns>
        private int GenerateNumber()
        {
            return _random.Next(10000, 9999999);
        }
        /// <summary>
        /// This method validate the invoice number
        /// </summary>
        /// <returns>it returns an integer</returns>
        public int GetInvoiceNumber()
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
        public string SaveSaleOrder(ISales sale,IDelivery delivery)
        {
            using (IDbConnection cn = new SqlConnection(SqlDataAccess.GetConnectionString()))
            {
                try
                {
                    var data = new DynamicParameters();
                    data.Add("@InvoiceNumber", sale.InvoiceNumber);
                    data.Add("@Discount", sale.Discount);
                    data.Add("@SubTotal", sale.SubTotal);
                    data.Add("@Tax", sale.Tax);
                    data.Add("@Total", sale.Total);
                    data.Add("@PaymentMode", sale.PaymentMode);
                    data.Add("@DeliveryMode", 1);
                    data.Add("@AccountId", 1);
                    data.Add("@QuotationId", 1);
                    data.Add("@UserId", 1);
                    data.Add("@SaleId", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    cn.Execute("spSales_insert", data, commandType: CommandType.StoredProcedure);
                    sale.SaleId = data.Get<int>("@SaleId");
                    delivery.SaleId = sale.SaleId;
                    _saleLineProcessor.SaveSaleLine(sale);
                    _deliveryProcessor.SaveDelivery(delivery);
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
        public List<SaleLine> GetSaleDetails(string invoiceNumber)
        {
            var output = SqlDataAccess.LoadSaleData(invoiceNumber);
            return output;
        }
    }
}
