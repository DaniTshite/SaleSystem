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
        static ICategory _category;
        public static void SaveCategory(ICategory category)
        {
            
            _category = category;
            string sql = @"spCategory_insert @CategoryName";
            SqlDataAccess.RegisterData(sql, _category);
        }
        
        public static List<Category> LoadData()
        {
            string sql = @"spCategory_GetAll";
            return SqlDataAccess.LoadData<Category>(sql);
        }
    }
}
