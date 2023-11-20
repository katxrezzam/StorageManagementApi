using Microsoft.EntityFrameworkCore;

namespace storageApi;

public class CustomerRepository(DataContext context) : ICustomerRepository
{
    private readonly DataContext _context = context;

    public async Task<bool> CreateCustomer(Customer customer)
    {
        _context.Customers.Add(customer);
        return await Save();
    }

    public Task<bool> CustomerExists(int customerId)
    {
        return _context.Customers.AnyAsync(c => c.CustomerId == customerId);
    }

    public async Task<Customer?> GetCustomer(int customerId)
    {
        return await _context.Customers.FindAsync(customerId);
    }

    public async Task<ICollection<Customer>> GetCustomers()
    {
        return await _context.Customers.ToListAsync();
    }

    public async Task<bool> RemoveCustomer(Customer customer)
    {
        _context.Customers.Remove(customer);
        return await Save();
    }

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateCustomer(Customer customer)
    {
        _context.Customers.Update(customer);
        return await Save();
    }
}
