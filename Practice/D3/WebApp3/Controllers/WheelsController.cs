using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp3.Models;
using Car;

namespace WebApp3.Controllers;

public class WheelsController : Controller
{
    private readonly ILogger<WheelsController> _logger;

    public WheelsController(ILogger<WheelsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Bugatti()
    {
        FourWheels fw = new FourWheels();
        fw.prodname = "Bugatti Chiron Pur Sport Grand Prix";
        fw.prodcompany = "Bugatti Automobiles S.A.S";
        fw.prodengine = "8.0 L (488 cu in) quad-turbocharged WR16";
        fw.prodcost = 20000000;
        fw.quantity = 1;
        fw.imageurl = "/Images/chiron.webp";
        ViewData["passcar"] = fw;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
