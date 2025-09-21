using WMS.Domain.Entities;

namespace WMS.Domain.Interfaces;

public interface IStockItemRepository
{
    List<StockItem> GetAll();
}
