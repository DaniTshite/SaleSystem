namespace DataLibrary.Models
{
    public interface ISupplier
    {
        string SupplierEmailAddress { get; set; }
        int SupplierId { get; set; }
        string SupplierName { get; set; }
        string SupplierPhysicalAddress { get; set; }
        string SupplierTelephone { get; set; }
    }
}