using WiredBrainCoffee.StorageApp.Entitities;

namespace WiredBrainCoffee.StorageApp.Repository
{
    public class EmployeeRepositoryWithRemove: GenericRepository<Employee>
    {
        public void Remove(Employee employee)
        {
            _items.Remove(employee);
        }
    }
}
