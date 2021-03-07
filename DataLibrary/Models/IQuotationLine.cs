namespace DataLibrary.Models
{
    public interface IQuotationLine
    {
        decimal LineTotal { get; set; }
        decimal RetailPrice { get; set; }
        Quotations Quotation { get; set; }
        int QuotationQuantity { get; set; }
        Item SelectedItem { get; set; }
    }
}