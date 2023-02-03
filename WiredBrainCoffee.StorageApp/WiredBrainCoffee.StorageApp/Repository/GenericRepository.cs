using System;
using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.StorageApp.Entitities;

namespace WiredBrainCoffee.StorageApp.Repository
{
   public class GenericRepository<T> where T:EntityBase
   {
        
       protected readonly List<T> _items = new();

        public T GetByID(int id)
        {
            return _items.Single(item => item.Id == id);
        }
        public void ADDEmployee(T item)
       {
            _items.Add(item);
       }

        public void SaveEmployee()
        {
            foreach(var employee in _items)
            {
                Console.WriteLine(employee);
            }
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

    }


    
}
