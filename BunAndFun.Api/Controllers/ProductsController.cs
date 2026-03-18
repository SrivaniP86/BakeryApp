using Microsoft.AspNetCore.Mvc;
using BunAndFun.Api.Data.Repositories;
using BunAndFun.Api.Models;

namespace BunAndFun.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductRepository _repository;

    public ProductsController(IProductRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
    {
        var products = await _repository.GetAllProductsAsync();
        return Ok(products);
    }
}