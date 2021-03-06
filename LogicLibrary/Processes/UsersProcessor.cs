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
    /// This class represents operations related to users
    /// </summary>
    public class UsersProcessor : IUsersProcessor
    {
        static IUsers _user;
        /// <summary>
        /// This method saves a user object into the DB
        /// </summary>
        /// <param name="user">It takes in an IUsers object as parameter</param>
        /// <returns>It returns a message showing the state of the operation</returns>
        public string SaveUser(IUsers user)
        {
            try
            {
                _user = user;
                string sql = @"spUsers_insert @TypeUser,@AccessCode,@Name,@LastName,@DoB,@IsActive,@Photo";
                SqlDataAccess.RegisterData(sql, _user);
                return "1 Record has been added Successfully !";
            }
            catch (Exception)
            {
                return " Something went wrong !";
            }

        }
        /// <summary>
        /// This method gets all users from the DB
        /// </summary>
        /// <returns>It returns a list of users objects</returns>
        public List<Users> GetUsers()
        {
            try
            {
                string sql = @"spUsers_GetAll";
                return SqlDataAccess.LoadData<Users>(sql);
            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// This method updates a user
        /// </summary>
        /// <param name="user">It takes in an IUsers object as parameter</param>
        /// <returns>It returns a message showing the state of the operation</returns>
        public string UpdateUser(IUsers user)
        {
            try
            {
                _user = user;
                string sql = @"spUsers_update @UserId,@TypeUser,@AccessCode,@Name,@LastName,@DoB,@IsActive,@Photo";
                SqlDataAccess.RegisterData(sql, _user);
                return "1 Record has been updated Successfully !";
            }
            catch (Exception)
            {
                return " Something went wrong !";
            }

        }
        /// <summary>
        /// This method generate a random access code
        /// </summary>
        /// <returns>It returns a string representing the access code</returns>
        public string GenerateAccessCode()
        {
            Random random = new Random();
            int orderNumber = random.Next(10000000);
            return "ACC" + orderNumber.ToString();
        }
    }
}
