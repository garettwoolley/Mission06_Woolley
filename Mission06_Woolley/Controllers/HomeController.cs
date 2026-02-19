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
        ViewBag.Categories = _context.Categories.OrderBy(x => x.CategoryName).ToList();
        return View("EnterMovie");
    }

    [HttpPost]
    public IActionResult EnterMovie(Movie movie)
    {
        _context.Movies.Add(movie); //Add record to the database
        _context.SaveChanges();
        return View("Confirmation", movie);
    }
    
    public IActionResult MovieList()
    {
       var movies = _context.Movies.ToList();

        return View(movies);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var recordToEdit = _context.Movies.Single(x => x.MovieId == id);
        
        ViewBag.Categories = _context.Categories.OrderBy(x => x.CategoryName).ToList();
        return View("EnterMovie", recordToEdit);
    }

    [HttpPost]
    public IActionResult Edit(Movie updatedInfo)
    {
        _context.Movies.Update(updatedInfo);
        _context.SaveChanges();
        return RedirectToAction("MovieList");
    }
}