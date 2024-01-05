using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Application.Models;
using BOL;
using BLL;

namespace Application.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        HMSManager hmgr = new HMSManager();
        List<Employee> elist = hmgr.AllEmployees();
        ViewData["Employees"] = elist;
        return View();
    }
    public IActionResult GetByIdPage(int id)
    {
        HMSManager hmgr = new HMSManager();
        Employee emp = hmgr.EmployeeById(id);
        TempData["Employee"] = emp;
        return View();
    }

    [HttpGet]
    public IActionResult GetById(int id){
        HMSManager hmgr = new HMSManager();
        Employee emp = hmgr.EmployeeById(id);
        TempData["Employee"] = emp;
        return View();
    }

    [HttpGet]
    public IActionResult Register(){
        return View();
    }
    [HttpPost]
    public IActionResult Register(int id, string name, string email, string contact){
        HMSManager hmgr = new HMSManager();
        hmgr.Register(id, name, email, contact);
        return RedirectToAction("Index");
    }
     [HttpGet]
    public IActionResult Update(){
        return View();
    }
    [HttpPost]
    public IActionResult Update(int id, string name, string email, string contact){
        HMSManager hmgr = new HMSManager();
        hmgr.Update(id, name, email, contact);
        return View();
    }
     [HttpGet]
    public IActionResult Delete(){
        return View();
    }
    [HttpPost]
    public IActionResult Delete(int id){
        HMSManager hmgr = new HMSManager();
        hmgr.Delete(id);
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
