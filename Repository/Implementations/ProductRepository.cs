
using Microsoft.EntityFrameworkCore;

namespace storageApi;

public class ProductRepository(DataContext context) : IProductRepository
{
    private readonly DataContext _context = context;

    public async Task<bool> CreateProduct(Product product)
    {
        _context.Products.Add(product);
        return await Save();
    }

    public async Task<Product?> GetProduct(int productId)
    {
        return await _context.Products.FindAsync(productId);
    }

    public async Task<ICollection<Product>> GetProducts()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<bool> ProductExists(int productId)
    {
        return await _context.Products.AnyAsync(p => p.ProductId == productId);
    }

    public async Task<bool> RemoveProduct(Product product)
    {
        _context.Products.Remove(product);
        return await Save();
    }

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateProduct(Product product)
    {
        _context.Products.Update(product);
        return await Save();
    }
}
