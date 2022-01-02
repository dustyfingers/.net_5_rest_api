using System.Collections.Generic;
using Catalog.Entities;

namespace Catalog.Repositories 
{

    public class InMemItemsRepository
    {

        // dont need new() List<Item> () etc in c# 9
        private readonly List<Item> items = new() 
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Iron Sword", Price = 10, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Bronze Shield", Price = 11, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Enchanted Staff", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
        };

        public IEnumerable<Item> GetItems()
        {

            return items;

        }

        public Item GetItem(Guid id)
        {

            return items.Where(x => x != null).Where(x => x.Id == id).SingleOrDefault();

        }

    }

}