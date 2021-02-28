using DataLibrary.Data;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{
    public class ItemProcessor
    {
        static IItem _item;
        public static void SaveItem(IItem item)
        {
            _item = item;
            string sql = @"spItem_insert @StockCode,@Descript,@Vat,@CategoryId,@IsActive,@ReOrderlevel";
            SqlDataAccess.RegisterData(sql, _item);
        }
        public static List<Item> LoadData()
        {
            string sql = @"spItem_GetAll";
            return SqlDataAccess.LoadData<Item>(sql);
        }

        public static void UpdateItemStatus(int itemId, int status)
        {
            var data = new
            {
                ItemId = itemId,
                Status = status
            };

            string sql = "spItem_UpdateStatus @ItemId,@Status";
            SqlDataAccess.RegisterData(sql, data);
        }
        public static decimal CalculateSalePrice(int itemId)
        {
            List<OrderLine> output = (SqlDataAccess.LoadEntryQuantities()).Where(x => x.SelectedItem.Itemid == itemId).ToList();
            if (output.Count == 0 || output == null)
            {
                return 0;
            }
            else
            {
                decimal price = output[0].PurchasePrice;
                int profit = output[0].SelectedItem.Profit;
                decimal salePrice = price + (price * profit / 100);
                return salePrice;
            }
            
        }
    }
}
