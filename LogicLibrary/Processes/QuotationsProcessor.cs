using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{
    public class QuotationsProcessor : IQuotationsProcessor
    {
        public int GetQuotationNumber()
        {
            throw new NotImplementedException();
        }

        public List<SaleLine> GetSaleDetails(string quotationNumber)
        {
            throw new NotImplementedException();
        }

        public string SaveSaleOrder(IQuotations quotation)
        {
            throw new NotImplementedException();
        }
    }
}
