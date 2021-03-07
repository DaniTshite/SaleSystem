using DataLibrary.Models;
using System.Collections.Generic;

namespace LogicLibrary.Processes
{
    public interface IOrderLineProcessor
    {
        List<OrderLine> GetEntryQuantityByItem();
        void SaveOrderLine(IOrders order);
    }
}