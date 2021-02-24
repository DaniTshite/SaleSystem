using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    /// <summary>
    /// This class represents a supplier
    /// </summary>
    public class Supplier : ISupplier
    {
        public int SupplierId { get; set; }
        [DisplayName("NAME")]
        public string SupplierName { get; set; }
        [DisplayName("TELEPHONE")]
        public string SupplierTelephone { get; set; }
        [DisplayName("EMAIL")]
        public string SupplierEmailAddress { get; set; }
        [DisplayName("ADDRESS")]
        public string SupplierPhysicalAddress { get; set; }
    }
}
