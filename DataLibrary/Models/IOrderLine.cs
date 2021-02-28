namespace DataLibrary.Models
{
    public interface IOrderLine
    {
        decimal LineTotal { get; set; }
        Orders Order { get; set; }
        int PurchasedQuantity { get; set; }
        decimal PurchasePrice { get; set; }
        Item SelectedItem { get; set; }
    }
}