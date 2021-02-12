using DataLibrary.Data;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{
    public class LoginProcessor
    {
        public static List<Users> LoadUsers(string accessCode,string password)
        {
            
            string sql = $"select * from Users where AccessCode='{accessCode}' and Pass='{password}'";
            return SqlDataAccess.LoadData<Users>(sql);
        }
    }
}
