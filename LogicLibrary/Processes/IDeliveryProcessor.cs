using DataLibrary.Models;
using System.Collections.Generic;

namespace LogicLibrary.Processes
{
    public interface IDeliveryProcessor
    {
        List<Delivery> GetDeliveries();
        void SaveDelivery(IDelivery delivery);
    }
}