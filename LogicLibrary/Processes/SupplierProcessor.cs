
using DataLibrary.Data;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{
    /// <summary>
    /// This class contains operations related to suppliers
    /// </summary>
    public class SupplierProcessor
    {
        static ISupplier _supplier;
        /// <summary>
        /// This method save a supplier object into the DB
        /// </summary>
        /// <param name="supplier">It takes in an ISupplier object as parameter</param>
        public static void SaveSupplier(ISupplier supplier)
        {
            try
            {
                _supplier = supplier;
                string sql = @"spSupplier_insert @SupplierName,@SupplierTelephone,@SupplierEmailAddress,@SupplierPhysicalAddress";
                SqlDataAccess.RegisterData(sql, _supplier);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        /// <summary>
        /// This method gets all suppliers from the DB
        /// </summary>
        /// <returns>It returns a list of supplier objects</returns>
        public static List<Supplier> LoadData()
        {
            try
            {
                string sql = @"spSupplier_GetAll";
                return SqlDataAccess.LoadData<Supplier>(sql);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        /// <summary>
        /// This method delete a supplier in the DB
        /// </summary>
        /// <param name="supplierid">It takes in an integer representing the supplierId as parameter</param>
        /// <returns>It returns a message showing whether the operation failed or succeeded</returns>
        public static string DeleteSupplier(int supplierid)
        {
            try
            {
                var data = new
                {
                    SupplierId = supplierid
                };
                string sql = "spSupplier_Delete @SupplierId";
                SqlDataAccess.RegisterData(sql, data);
                return "1 Record has been deleted Successfully !";
            }
            catch (Exception)
            {
                return " Something went wrong !";
            }
        }
        
    }
}
