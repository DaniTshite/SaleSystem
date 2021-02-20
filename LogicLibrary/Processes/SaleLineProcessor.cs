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
            foreach (var item in sale.Details)
            {
                var data = new
                {
                    SaleId=sale.SaleId,
                    ItemId = item.SelectedItem.Itemid,
                    RetailPrice = item.RetailPrice,
                    SaleQuantity = item.SaleQuantity,
                    LineTotal = item.LineTotal
                };
                string sql = @"spOrderLine_insert @SaleId,@ItemId,@SaleQuantity,@RetailPrice,@LineTotal";
                SqlDataAccess.RegisterData(sql, data);
            }
        }
    }
}
