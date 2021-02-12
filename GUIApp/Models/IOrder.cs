namespace GUIApp.Models
{
    public interface IOrder
    {
        int Id { get; set; }
        
        string Descript { get; set; }
        
        string StockCode { get; set; }

        int PurchasedQuantity { get; set; }
    }
}