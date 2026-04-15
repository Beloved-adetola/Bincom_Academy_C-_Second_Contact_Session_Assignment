using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Portfolio.Models;

namespace MVC_Portfolio.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About() => View();
    public IActionResult Skills() => View();
    public IActionResult Projects() => View();
    public IActionResult Contact() => View();

    public IActionResult Experience()
    {
        return View();
    }

    [HttpGet]
    public IActionResult TaxCalculator() => View();

    [HttpPost]
    public IActionResult TaxCalculator(decimal income)
    {
        decimal tax = CalculateTax(income);
        ViewBag.Tax = tax;
        return View();
    }

    private decimal CalculateTax(decimal income)
{
    if (income <= 300000) return income * 0.07m;
    else if (income <= 600000) return income * 0.11m;
    else if (income <= 1100000) return income * 0.15m;
    else if (income <= 1600000) return income * 0.19m;
    else if (income <= 3200000) return income * 0.21m;
    else return income * 0.24m;
}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
