using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using IN451_Unit2.Models;
using IN451_Unit2.Services.Interfaces;

namespace IN451_Unit2.Web.Controllers;

public class HomeController : Controller
{
    private readonly ICustomerService _customerService;

    public HomeController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    public IActionResult Index()
    {
        // Retrieve customer data using the service layer
        var customerInfo = _customerService.GetCustomerInfo();

        return View(customerInfo);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
