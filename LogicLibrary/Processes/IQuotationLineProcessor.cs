using DataLibrary.Models;

namespace LogicLibrary.Processes
{
    public interface IQuotationLineProcessor
    {
        void SaveQuotationLine(IQuotations quotation);
    }
}