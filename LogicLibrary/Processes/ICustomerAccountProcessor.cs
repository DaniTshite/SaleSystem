using DataLibrary.Models;
using System.Collections.Generic;

namespace LogicLibrary.Processes
{
    public interface ICustomerAccountProcessor
    {
        List<CustomerAccount> GetCustomerAccounts();
        string SaveCustomerAccount(ICustomerAccount customerAccount);
    }
}