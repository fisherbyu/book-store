using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookStoreApp.Models;

namespace BookStoreApp.Controllers;

public class HomeController : Controller
{
    // Attributes
    private BookstoreContext bookStoreContext;
    private readonly ILogger<HomeController> _logger;

    // Constructor
    public HomeController(ILogger<HomeController> logger, BookstoreContext context)
    {
        // Initialize Attributes
        _logger = logger;
        bookStoreContext = context;
    }

    public IActionResult Index()
    {
        List<Book> data = bookStoreContext.Books
            .ToList();

        return View(data);
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

