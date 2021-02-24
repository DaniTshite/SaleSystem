using System;

namespace DataLibrary.Models
{
    public interface IUsers
    {
        string AccessCode { get; set; }
        DateTime DoB { get; set; }
        string FullName { get; }
        int IsActive { get; set; }
        string LastName { get; set; }
        string Name { get; set; }
        byte[] Photo { get; set; }
        string TypeUser { get; set; }
        int UserId { get; set; }
    }
}