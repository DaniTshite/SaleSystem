namespace DataLibrary.Models
{
    public interface IItem
    {
        string barCode { get; set; }
        int CategoryId { get; set; }
        string Descript { get; set; }
        int IsActive { get; set; }
        int Itemid { get; set; }
        int Profit { get; set; }
        int ReOrderlevel { get; set; }
        string StockCode { get; set; }
        int Vat { get; set; }
    }
}