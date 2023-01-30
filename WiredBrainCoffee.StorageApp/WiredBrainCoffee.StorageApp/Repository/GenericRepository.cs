using System;
using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entitities;

namespace WiredBrainCoffee.StorageApp.Repository
{
    class GenericRepository<T>
    {
        private readonly List<T> _items = new(); 

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

    }
}
