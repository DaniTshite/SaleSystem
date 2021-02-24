using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    /// <summary>
    /// This class represents a user of the system
    /// </summary>
    public class Users : IUsers
    {
        public int UserId { get; set; }
        public string TypeUser { get; set; }
        public string AccessCode { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public int IsActive { get; set; }
        public byte[] Photo { get; set; }
        public string FullName
        {
            get { return $"{Name}  {LastName}"; }
        }

    }
}
