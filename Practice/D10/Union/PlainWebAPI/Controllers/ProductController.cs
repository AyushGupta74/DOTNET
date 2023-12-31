using Microsoft.AspNetCore.Mvc;
using pwa.bol;
using pwa.bll;
using pwa.dal.connected;
namespace ReactWithWebAPIApp.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Product> Get()
    {
        ProductManager p = new ProductManager();
        List<Product> products = p.GetAllProducts();
        return products.ToArray();
    }

    // [HttpPost]
    // public IEnumerable<Product> Post()
    // {
    //     ProductManager p = new ProductManager();
    //     List<Product> products = p.GetAllProducts();
    //     return products.ToArray();
    // }

    [HttpGet("{id}")]
    public Product GetById(int id)
    {
        ProductManager p = new ProductManager();
        Product pr = p.GetProduct(id);
        return pr;
    }

    // [HttpPost("{id}")]
    // public Product PostById(int id)
    // {
    //     ProductManager p = new ProductManager();
    //     Product pr = p.GetProduct(id);
    //     return pr;
    // }

    // [HttpGet("{name}")]
    // public Product GetByCompany(string name)
    // {
    //     ProductManager p = new ProductManager();
    //     Product pr = p.GetProductByCompany(name);
    //     return pr;
    // }

    // [HttpPost("{name}")]
    // public Product PostByCompany(string name)
    // {
    //     ProductManager p = new ProductManager();
    //     Product pr = p.GetProductByCompany(name);
    //     return pr;
    // }
}
