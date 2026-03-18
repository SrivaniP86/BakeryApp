using Microsoft.EntityFrameworkCore;
using BunAndFun.Api.Models;
using BunAndFun.Api.Data;

namespace BunAndFun.Api.Data.Repositories;

// the interface - (The contract)
public interface IProductRepository
{
	Task<IEnumerable<Product>> GetAllProductsAsync();
}

// the implementation - (The worker)
public class ProductRepository : IProductRepository
{
	private readonly AppDbContext _context;
	public ProductRepository(AppDbContext context) => _context = context;

	public async Task<IEnumerable<Product>> GetAllProductsAsync()
		=> await _context.Products.ToListAsync();
}