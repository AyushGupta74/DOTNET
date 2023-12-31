using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using BOL;
using BLL;
using System.Collections.Generic;

namespace WebApp.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult AllProducts()
    {
        Catalog cg = new Catalog();
        List<Product> products = cg.GetAllProducts();
        ViewData["allProducts"] = products;
        return View();
    }
    
    public IActionResult SearchById(int id)
    {
        Catalog cg = new Catalog();
        Product p = cg.GetProductById(id);
        TempData["productById"] = p;
        if(p!=null){
            return this.RedirectToAction("ProductFound");
        }
    }

    public IActionResult ProductFound(Product p)
    {
        TempData["productById"] = p;
        return View();
    }
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
