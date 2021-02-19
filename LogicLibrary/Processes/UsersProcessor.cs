using DataLibrary.Data;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{
    public class UsersProcessor
    {
        public static void SaveUser(Users model)
        {
            var data = new
            {
                TypeUser=model.TypeUser,
                AccessCode=model.AccessCode,
                Name=model.Name,
                LastName=model.LastName,
                DoB=model.DoB,
                IsActive=model.IsActive,
                Photo=model.Photo
            };
            string sql = @"spUsers_insert @TypeUser,@AccessCode,@Name,@LastName,@DoB,@IsActive,@Photo";
            SqlDataAccess.RegisterData(sql, data);
        }

        public static string GenerateAccessCode()
        {
            Random random = new Random();
            int orderNumber = random.Next(10000000);
            return "ACC" + orderNumber.ToString();
        }
    }
}
