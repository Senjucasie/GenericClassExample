using System;
using System.Collections.Generic;
using System.Linq;

namespace WiredBrainCoffee.StorageApp.Repository
{
   public class GenericRepository<T>
   {
        
       protected readonly List<T> _items = new(); 

       //public T GetByID(int id)
       // {
       //     return _items.Select(item=> item.)
       // }
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
