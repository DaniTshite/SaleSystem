using DataLibrary.Data;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{
    public class SaleLineProcessor
    {
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
