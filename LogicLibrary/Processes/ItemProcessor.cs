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
    /// This class contains processes relating to items
    /// </summary>
    public class ItemProcessor : IItemProcessor
    {
        static IItem _item;
        /// <summary>
        /// This method saves an item object into a DB
        /// </summary>
        /// <param name="item">It takes in an IItem as parameter </param>
        public void SaveItem(IItem item)
        {
            _item = item;
            string sql = @"spItem_insert @StockCode,@Descript,@Vat,@CategoryId,@IsActive,@ReOrderlevel";
            SqlDataAccess.RegisterData(sql, _item);
        }
        /// <summary>
        /// This method get all items from a DB
        /// </summary>
        /// <returns>It returns a list of Item objects</returns>
        public List<Item> GetItems()
        {
            string sql = @"spItem_GetAll";
            return SqlDataAccess.LoadData<Item>(sql);
        }
        /// <summary>
        /// This method get all active items from a DB to be used on sales
        /// </summary>
        /// <returns>It returns a list of Item objects</returns>
        public List<Item> GetActiveItemsSale()
        {
            string sql = @"spItem_GetAllActive";
            return SqlDataAccess.LoadData<Item>(sql);
        }
        /// <summary>
        /// This method get all active items from a DB to be used on supplies
        /// </summary>
        /// <returns>It returns a list of Item objects</returns>
        public List<Item> GetActiveItemsSupply()
        {
            string sql = @"spItem_GetAllActiveSupply";
            return SqlDataAccess.LoadData<Item>(sql);
        }
        /// <summary>
        /// This method update the status of an item
        /// </summary>
        /// <param name="itemId">This is a int parameter representing the itemId</param>
        /// <param name="status">This is a int parameter representing the status</param>
        public void UpdateItemStatus(int itemId, int status)
        {
            var data = new
            {
                ItemId = itemId,
                Status = status
            };

            string sql = "spItem_UpdateStatus @ItemId,@Status";
            SqlDataAccess.RegisterData(sql, data);
        }
        /// <summary>
        /// This method calculate the sale price based on the purchase price and profit of an item
        /// </summary>
        /// <param name="itemId">this int parameter represents the itemId</param>
        /// <returns>It returns a decimal value</returns>
        public decimal CalculateSalePrice(int itemId)
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
