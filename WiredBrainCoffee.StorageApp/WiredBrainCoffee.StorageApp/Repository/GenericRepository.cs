using System;
using System.Collections.Generic;

namespace WiredBrainCoffee.StorageApp.Repository
{
   public class GenericRepository<T>
   {
       protected readonly List<T> _items = new(); 

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
