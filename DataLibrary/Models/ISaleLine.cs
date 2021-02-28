namespace DataLibrary.Models
{
    public interface ISaleLine
    {
        decimal LineTotal { get; set; }
        decimal RetailPrice { get; set; }
        Sales Sale { get; set; }
        int SaleQuantity { get; set; }
        Item SelectedItem { get; set; }
    }
}