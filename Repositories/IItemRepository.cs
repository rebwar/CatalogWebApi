namespace Catalog.Repositories
{
    public interface IItemRepository
    {
        Item getItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}