using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAll();
        IEnumerable<Item> GetEntityByType(string type);
        Item GetById(int id);
        Item Update(Item updatedItem);
        Item Create(Item newItem);
        Item delete(int id);
        int GetCount();
        int Commit();
    }
}
