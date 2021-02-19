using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIApp.Models
{
    public class OrdersByMonth
    {
        [DisplayName("No")]
        public int Counter { get; set; }
        [DisplayName("ORDER")]
        public string OrderNumber { get; set; }
        [DisplayName("DATE")]
        public DateTime OrderDate { get; set; }
        [DisplayName("TOTAL")]
        public double Total { get; set; }
        [DisplayName("SUPPLIER")]
        public string SupplierName { get; set; }
        [DisplayName("TELEPHONE")]
        public string SupplierTelephone { get; set; }
    }
}
