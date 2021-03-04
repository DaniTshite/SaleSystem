namespace DataLibrary.Models
{
    public interface ISaleLine
    {
        Item SelectedItem { get; set; }
        Sales Sale { get; set; }
        decimal RetailPrice { get; set; }
        int SaleQuantity { get; set; }
        decimal LineTotal { get; set; }
    }
}