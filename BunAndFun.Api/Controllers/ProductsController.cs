using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BunAndFun.Api.Data;
using BunAndFun.Api.Models;

namespace BunAndFun.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProductsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
    {
        return await _context.Products.AsNoTracking().ToListAsync();
    }
}