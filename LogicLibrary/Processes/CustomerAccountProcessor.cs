using DataLibrary.Data;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{
    /// <summary>
    /// This class contains operations relating to customer account
    /// </summary>
    public class CustomerAccountProcessor : ICustomerAccountProcessor
    {
        static ICustomerAccount _customerAccount;
        /// <summary>
        /// This method saves a customerAccount object into the DB
        /// </summary>
        /// <param name="customerAccount">It takes in an ICustomerAccount object as parameter</param>
        /// <returns>It returns a string value</returns>
        public string SaveCustomerAccount(ICustomerAccount customerAccount)
        {
            try
            {
                _customerAccount = customerAccount;
                string sql = @"spCustomerAccount_insert @FirstName,@LastName, @IdNumber,@Cellphone,@EmailAddress,@PhysicalAddress,@Gender";
                SqlDataAccess.RegisterData(sql, _customerAccount);
                return "1 Record has been saved successfully !";
            }
            catch (Exception)
            {
                return "Something went wrong !";
            }

        }
        /// <summary>
        /// This method get all customer accounts from the DB
        /// </summary>
        /// <returns>It returns a list of CustomerAccounts</returns>
        public List<CustomerAccount> GetCustomerAccounts()
        {
            try
            {
                string sql = @"spCustomerAccount_GetAll";
                return SqlDataAccess.LoadData<CustomerAccount>(sql);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
