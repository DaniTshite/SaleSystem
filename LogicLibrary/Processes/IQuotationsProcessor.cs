using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{
    public interface IQuotationsProcessor
    {
        int GetQuotationNumber();
        List<QuotationLine> GetQuotationDetails(string quotationNumber);
        string SaveQuotation(IQuotations quotation);
        List<Quotations> GetQuotations();
    }
}
