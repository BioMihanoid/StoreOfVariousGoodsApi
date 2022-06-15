namespace StoreOfVariousGoodsApi.Models;

public class Sale
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public DateTime Time { get; set; }
    public int SalesPointId { get; set; }
    public int? BuyerId { get; set; }
    public SaleData SalesData { get; set; } = null!;
    public int TotalAmount { get; set; }
}