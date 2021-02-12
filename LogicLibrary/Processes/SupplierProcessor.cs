
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
    public class SupplierProcessor
    {
        public static void SaveSupplier(Supplier model)
        {
           Supplier data = new Supplier
            {
               SupplierName= model.SupplierName,
               SupplierTelephone= model.SupplierTelephone,
               SupplierEmailAddress= model.SupplierEmailAddress,
               SupplierPhysicalAddress= model.SupplierPhysicalAddress
           };
            
            string sql = @"spSupplier_insert @SupplierName,@SupplierTelephone,@SupplierEmailAddress,@SupplierPhysicalAddress";

            SqlDataAccess.RegisterData(sql, data);
        }

        public static List<Supplier> LoadData()
        {
            string sql = @"spSupplier_GetAll";
            return SqlDataAccess.LoadData<Supplier>(sql);
        }

        public static bool IsEmailValid(string email)
        {
            
            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            if (Regex.IsMatch(email, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
