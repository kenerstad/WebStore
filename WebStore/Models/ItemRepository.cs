using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;

namespace WebStore.Models
{
    public class ItemRepository : IItemRepository
    {

        private readonly WebStoreDbContext _webStoreDbContext;

        public ItemRepository(WebStoreDbContext webStoreDbContext)
        {
            _webStoreDbContext = webStoreDbContext;
        }

        public int Commit()
        {
            return _webStoreDbContext.SaveChanges();
        }

        public Item Create(Item newItem)
        {
            _webStoreDbContext.Add(newItem);
            return newItem;
        }

        public Item delete(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                _webStoreDbContext.Remove(item);
            }
            return item;
        }

        public IEnumerable<Item> GetAll()
        {
            return _webStoreDbContext.Items;
        }

        public Item GetById(int id)
        {
            return _webStoreDbContext.Items.FirstOrDefault(p => p.id == id);
        }

        public int GetCount()
        {
            return _webStoreDbContext.Items.Count();
        }

        public IEnumerable<Item> GetEntityByType(string type)
        {
            var query = from r in _webStoreDbContext.Items
                        where r.type.StartsWith(type) || string.IsNullOrEmpty(type)
                        orderby r.type
                        select r;
            return query;
        }

        public Item Update(Item updatedItem)
        {
            var item = _webStoreDbContext.Items.Attach(updatedItem);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return updatedItem;
        }
    }
}
