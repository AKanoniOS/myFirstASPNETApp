using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Models;

namespace MyFirstApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.myString = "This is the first index of my array of integers";
        int[] myArray = { 1, 2, 3, 4, 5 };
        ViewBag.myArray = myArray;
        ViewBag.myBool = true;
        ViewBag.myBoolString = "This is my bool ->";
        string newString = "nothing here yet ";
        for (int i = 0; i < 5; i++)
        {
            newString += $", round {i}";
        }
        ViewBag.newString = newString;
        ViewBag.newStringIntro = "I used a for loop and string interpolation to create this string ->";
        return View();
    }

    public IActionResult Privacy()
    {
        
        ViewBag.Message = "This is my ViewBag message string.";
        
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

