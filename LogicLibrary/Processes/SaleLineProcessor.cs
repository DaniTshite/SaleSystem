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
    /// This class contains processes related to sale order details
    /// </summary>
    public class SaleLineProcessor
    {
        /// <summary>
        /// This method saves a saleline object into the the DB
        /// </summary>
        /// <param name="sale">this is a parameter of type Sales</param>
        public static void SaveSaleLine(Sales sale)
        {
            foreach (var item in sale.SaleOrderDetails)
            {
                var data = new
                {
                    ItemId = item.SelectedItem.Itemid,
                    SaleId = sale.SaleId,
                    SaleQuantity = item.SaleQuantity,
                    RetailPrice = item.RetailPrice,
                    LineTotal = item.LineTotal
                };
                string sql = @"spSaleLine_insert @ItemId,@SaleId,@SaleQuantity,@RetailPrice,@LineTotal";
                SqlDataAccess.RegisterData(sql, data);
            }
        }
    }
}
