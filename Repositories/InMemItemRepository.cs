using Catalog.Entities;
namespace Catalog.Repositories
{
    public class InMemItemRepository
    {
        private readonly List<Item> items=new(){
            new Item{
                Id=Guid.NewGuid(),
                Name="Potion",
                Price=9,
                CreatedDate=DateTimeOffset.UtcNow
            },
            new Item{
                Id=Guid.NewGuid(),
                Name="Iron Sword",
                Price=20,
                CreatedDate=DateTimeOffset.UtcNow
            },
            new Item{
                Id=Guid.NewGuid(),
                Name="Bronze Sheild",
                Price=17,
                CreatedDate=DateTimeOffset.UtcNow
            }

        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item getItem(Guid id)
        {
            var result=items.Where(c=>c.Id==id).SingleOrDefault();
            return result;
        }
    }
}