using System;
using System.Collections.Generic;
using WiredBrainCoffee.StorageApp.Entitities;

namespace WiredBrainCoffee.StorageApp.Repository
{
    class EmployeeRepository
    {
        private readonly List<Employee> _employees = new(); 

        public void ADDEmployees(Employee employee)
        {
            _employees.Add(employee);
        }

        public void SaveEmployee()
        {
            foreach(var employee in _employees)
            {
                Console.WriteLine(employee);
            }
        }

    }
}
