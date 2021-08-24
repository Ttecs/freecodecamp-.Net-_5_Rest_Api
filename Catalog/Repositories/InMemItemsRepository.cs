using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repositories
{
   
    public class InMemItemsRepository : IItemsRepository
    {
        private readonly List<Item> _items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "call of duty", Price = 20, CreateDate = DateTime.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Far cry", Price = 45, CreateDate = DateTime.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "MGSV", Price = 46, CreateDate = DateTime.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Dirt", Price = 98, CreateDate = DateTime.UtcNow },
        };
        public IEnumerable<Item> GetItems()
        {
            return _items;
        }
        public Item GetItem(Guid id)
        {
            return _items.Where(item => item.Id == id).SingleOrDefault();
        }
    }
}