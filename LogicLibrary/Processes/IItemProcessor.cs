using DataLibrary.Models;
using System.Collections.Generic;

namespace LogicLibrary.Processes
{
    public interface IItemProcessor
    {
        decimal CalculateSalePrice(int itemId);
        List<Item> GetActiveItemsSale();
        List<Item> GetActiveItemsSupply();
        List<Item> GetItems();
        void SaveItem(IItem item);
        void UpdateItemStatus(int itemId, int status);
    }
}