namespace Catalog.Repositories
{
    public interface IItemRepository
    {
        Item getItem(Guid id);
        IEnumerable<Item> GetItems();

        void CreateItem(Item item);

        void UpdateItem(Item item);

        
    }
}