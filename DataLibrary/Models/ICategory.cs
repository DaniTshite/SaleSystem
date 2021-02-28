using System.Collections.Generic;

namespace DataLibrary.Models
{
    public interface ICategory
    {
        int CategoryId { get; set; }
        string CategoryName { get; set; }
        List<Item> listItems { get; set; }
    }
}