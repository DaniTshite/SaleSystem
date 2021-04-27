using DataLibrary.Models;
using System.Collections.Generic;

namespace LogicLibrary.Processes
{
    public interface ISalesProcessor
    {
        int GetInvoiceNumber();
        List<SaleLine> GetSaleDetails(string invoiceNumber);
        string SaveSaleOrder(ISales model,IDelivery delivery);
        List<Sales> GetNonDeliveredOrders();
    }
}