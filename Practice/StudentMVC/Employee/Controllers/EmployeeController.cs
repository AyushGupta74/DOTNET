using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Employee.Models;
using BLL;
using BOL;
using DAL;

namespace Employee.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult CreateLogic()
    {
        return View();
    }

    public IActionResult Create(int id, string fname, string lname, string email, DateTime dob , string pw)
    {
        TableEmployee te = new TableEmployee(id,fname,lname,email,dob,pw);
        // te.Id=(int)id;
        // te.FirstName=fname;
        // te.LastName=lname;
        // te.Email=email;
        // te.Dob=dob;
        // te.Password=pw;
        EmployeeManager e = new EmployeeManager();
        e.EmployeeCreation(te);
        // return RedirectToAction("Mainpage");
        return View();
    }
    // public IActionResult Create(int id, string fname, string lname, string email, DateTime dob , string pw){
    //     DBManager.EmployeeCreation(id,fname,lname,email,dob,pw);
    //     // return RedirectToAction("Mainpage");
    //     return View();
    // }
    public IActionResult Read()
    {
        EmployeeManager e =new EmployeeManager();
        List<TableEmployee> elist = e.GetAllEmployees();
        ViewData["AllEmployee"]= elist;
        return View();
    }


    public IActionResult Update(TableEmployee temp)
    {
        return View();
    }

    public IActionResult Delete(TableEmployee temp)
    {
        return View();
    }

    public IActionResult MainPage()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
