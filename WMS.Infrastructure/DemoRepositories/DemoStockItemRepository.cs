using WMS.Domain.Entities;
using WMS.Domain.Interfaces;

namespace WMS.Infrastructure.DemoRepositories;

public class DemoStockItemRepository : IStockItemRepository
{
    private List<StockItem> _items =
    [
        new StockItem
        {
            Id = 1,
            Name = "12\" White Latex Balloons 100pcs",
            Quantity = 100
        },
        new StockItem
        {
            Id = 2,
            Name = "12\" Light Blue Latex Balloons 100pcs",
            Quantity = 100
        },
        new StockItem
        {
            Id = 3,
            Name = "12\" Blue Chrome Latex Balloons 100pcs",
            Quantity = 100
        },
        new StockItem
        {
            Id = 4,
            Name = "12\" Blue Confetti Latex Balloons 100pcs",
            Quantity = 100
        },
        new StockItem
        {
            Id = 5,
            Name = "Blue Number 0 Foil Balloon 40\"",
            Quantity = 100
        },
        new StockItem
        {
            Id = 6,
            Name = "Blue Number 1 Foil Balloon 40\"",
            Quantity = 100
        },
        new StockItem
        {
            Id = 7,
            Name = "Blue Number 2 Foil Balloon 40\"",
            Quantity = 100
        },
        new StockItem
        {
            Id = 8,
            Name = "Blue Number 3 Foil Balloon 40\"",
            Quantity = 100
        },
        new StockItem
        {
            Id = 9,
            Name = "Blue Number 4 Foil Balloon 40\"",
            Quantity = 100
        },
        new StockItem
        {
            Id = 10,
            Name = "Blue Number 5 Foil Balloon 40\"",
            Quantity = 100
        },
        new StockItem
        {
            Id = 11,
            Name = "Blue Number 6 Foil Balloon 40\"",
            Quantity = 100
        },
        new StockItem
        {
            Id = 12,
            Name = "Blue Number 7 Foil Balloon 40\"",
            Quantity = 100
        },
        new StockItem
        {
            Id = 13,
            Name = "Blue Number 8 Foil Balloon 40\"",
            Quantity = 100
        },
        new StockItem
        {
            Id = 14,
            Name = "Blue Number 9 Foil Balloon 40\"",
            Quantity = 100
        }
    ];

    public List<StockItem> GetAll() => [.. _items];
}
