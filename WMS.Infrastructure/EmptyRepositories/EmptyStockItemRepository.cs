using WMS.Domain.Entities;
using WMS.Domain.Interfaces;

namespace WMS.Infrastructure.EmptyRepositories;

public class EmptyStockItemRepository : IStockItemRepository
{
    private List<StockItem> _items = [];

    public List<StockItem> GetAll() => [.. _items];
}
