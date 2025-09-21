namespace WMS.Domain.Entities;

public class StockItem
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Quantity { get; set; }
}
