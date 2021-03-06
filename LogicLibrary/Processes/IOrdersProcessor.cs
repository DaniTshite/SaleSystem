using DataLibrary.Models;
using System.Collections.Generic;

namespace LogicLibrary.Processes
{
    public interface IOrdersProcessor
    {
        List<OrderLine> GetInactiveItems(List<Item> items);
        List<OrderLine> GetItemsToReorder(List<Item> items);
        List<OrderLine> GetOrderDetails(string orderNumber);
        //bool IsStockQuantityEnough(int firstNumber, int secondNumber);
        string SaveSupplyOrder(Orders model);
    }
}