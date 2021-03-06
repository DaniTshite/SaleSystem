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
    /// This class contains processes relating to categories of an item
    /// </summary>
    public class CategoryProcessor : ICategoryProcessor
    {
        static ICategory _category;
        /// <summary>
        /// This method saves a category object into a DB
        /// </summary>
        /// <param name="category">this is an ICategory object</param>
        public void SaveCategory(ICategory category)
        {
            _category = category;
            string sql = @"spCategory_insert @CategoryName";
            SqlDataAccess.RegisterData(sql, _category);
        }
        /// <summary>
        /// this method gets all categories from a DB
        /// </summary>
        /// <returns>It returns a list of category objects</returns>
        public List<Category> GetCategories()
        {
            string sql = @"spCategory_GetAll";
            return SqlDataAccess.LoadData<Category>(sql);
        }
    }
}
