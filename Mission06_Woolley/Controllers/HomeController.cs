using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Woolley.Models;

namespace Mission06_Woolley.Controllers;

public class HomeController : Controller
{

    private MovieContext _context;
    
  
    public HomeController(MovieContext temp)
    {
        _context = temp;
    }
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetToKnowJoel()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult EnterMovie()
    {
        return View();
    }

    [HttpPost]
    public IActionResult EnterMovie(Movie movie)
    {
        _context.Movies.Add(movie); //Add record to the database
        _context.SaveChanges();
        return View("Confirmation", movie);
    }
}