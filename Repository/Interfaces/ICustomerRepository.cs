namespace storageApi;

public interface ICustomerRepository
{
    Task<ICollection<Customer>> GetCustomers();
    Task<Customer?> GetCustomer(int customerId);
    Task<bool> CustomerExists(int customerId);
    Task<bool> CreateCustomer(Customer customer);
    Task<bool> RemoveCustomer(Customer customer);
    Task<bool> UpdateCustomer(Customer customer);
    Task<bool> Save();
}
