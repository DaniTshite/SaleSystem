using DataLibrary.Data;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.HelperProcesses
{
    
    public class HelperProcessor
    {
        private static int StockQuantity { get; set; } = 0;
        /// <summary>
        /// This method calculate the stock quantity of a particular item
        /// </summary>
        /// <param name="ItemId"></param>
        /// <returns>it returns the stock quantity of a given item</returns>
        public static int GetStockQuantity(int itemId)
        {
            
            var _in = SqlDataAccess.LoadEntryQuantities().Where(x=>x.SelectedItem.Itemid==itemId).ToList();
            var _out = SqlDataAccess.LoadSoldQuantities().Where(x => x.SelectedItem.Itemid == itemId).ToList();
            
            if (_in == null || _in.Count == 0 )
            {
                return StockQuantity;
            }
            else
            {
                int entry = _in[0].PurchasedQuantity;
                if (_out == null || _out.Count == 0)
                {
                    StockQuantity = entry;
                    return StockQuantity;
                }
                else
                {
                    int sold = _out[0].SaleQuantity;
                    StockQuantity = entry - sold;
                    return StockQuantity;
                }
            }
             
        }
    }
}
