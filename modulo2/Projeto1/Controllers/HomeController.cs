using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Projeto1.Models;

namespace Projeto1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public void Acao01()
    {
        Console.WriteLine("Teste ação 01");
    }

    public string Acao02()
    {
        return "Teste ação 02";
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
