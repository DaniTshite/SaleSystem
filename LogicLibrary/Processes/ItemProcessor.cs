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
        public static void SaveItem(Item model)
        {
            Item data = new Item
            {
                StockCode = model.StockCode,
                Descript = model.Descript,
                Vat = model.Vat,
                CategoryId = model.CategoryId,
                IsActive = model.IsActive,
                ReOrderlevel = model.ReOrderlevel
            };
            string sql = @"spItem_insert @StockCode,@Descript,@Vat,@CategoryId,@IsActive,@ReOrderlevel";

            SqlDataAccess.RegisterData(sql, data);
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
            List<OrderLine> output = (SqlDataAccess.LoadEntryPrices()).Where(x => x.SelectedItem.Itemid == itemId).ToList();
                
            decimal price = output[0].PurchasePrice;
            int profit = output[0].SelectedItem.Profit;
            decimal salePrice = price + ( price *  profit /100);
            return salePrice;
        }
    }
}
