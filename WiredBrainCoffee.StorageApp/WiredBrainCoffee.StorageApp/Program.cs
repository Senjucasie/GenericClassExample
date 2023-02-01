using System;
using WiredBrainCoffee.StorageApp.Entitities;
using WiredBrainCoffee.StorageApp.Repository;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepositoryWithRemove<Employee>();
            employeeRepository.ADDEmployee(new Employee { FirstName = "Julia" });
            employeeRepository.ADDEmployee(new Employee { FirstName = "frank" });
            employeeRepository.ADDEmployee(new Employee { FirstName = "jeo" });
            employeeRepository.SaveEmployee();

            var organisationrepository = new GenericRepositoryWithRemove<Organisation>();
            organisationrepository.ADDEmployee(new Organisation { Name = "horlicks" });
            organisationrepository.ADDEmployee(new Organisation { Name = "nike" });
            organisationrepository.SaveEmployee();
        }
    }
}
