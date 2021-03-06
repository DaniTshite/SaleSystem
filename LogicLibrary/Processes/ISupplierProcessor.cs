using DataLibrary.Models;
using System.Collections.Generic;

namespace LogicLibrary.Processes
{
    public interface ISupplierProcessor
    {
        string DeleteSupplier(int supplierid);
        List<Supplier> GetSuppliers();
        void SaveSupplier(ISupplier supplier);
    }
}