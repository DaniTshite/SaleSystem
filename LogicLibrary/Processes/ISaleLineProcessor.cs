using DataLibrary.Models;

namespace LogicLibrary.Processes
{
    public interface ISaleLineProcessor
    {
        void SaveSaleLine(ISales sale);
    }
}