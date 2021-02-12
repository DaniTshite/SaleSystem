using DataLibrary.Data;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary.Processes
{
    public class CategoryProcessor
    {
        public static void SaveCategory(Category model)
        {
            Category data = new Category
            {
                CategoryName=model.CategoryName
            };
            string sql = @"spCategory_insert @CategoryName";

            SqlDataAccess.RegisterData(sql, data);
        }

        public static List<Category> LoadData()
        {
            string sql = @"spCategory_GetAll";
            return SqlDataAccess.LoadData<Category>(sql);
        }
    }
}
