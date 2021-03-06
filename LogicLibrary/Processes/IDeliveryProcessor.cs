using DataLibrary.Models;
using System.Collections.Generic;

namespace LogicLibrary.Processes
{
    public interface IDeliveryProcessor
    {
        List<Delivery> GetDeliveries();
        string SaveDelivery(IDelivery delivery);
    }
}