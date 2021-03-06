using DataLibrary.Models;
using System.Collections.Generic;

namespace LogicLibrary.Processes
{
    public interface ICategoryProcessor
    {
        List<Category> GetCategories();
        void SaveCategory(ICategory category);
    }
}