using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
            new MovieViewModel { Id = 1, Name = "Titanic", rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", image = }
            new MovieViewModel { Id = 2, Name = "Inception", rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller", image = }
            new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", rating = "5", ReleaseYear = 1994, Genre = "Drama", image = }
            new MovieViewModel { Id = 4, Name = "Nanny McPhee", rating = "4", ReleaseYear = 2005, Genre = "Fantasy", image = }
            new MovieViewModel { Id = 5, Name = "Matilda", rating = "4", ReleaseYear = 1996, Genre = "Fantasy", image = }
            new MovieViewModel { Id = 6, Name = "Luck", rating = "4", ReleaseYear = 2002, Genre = "Comedy", image = }
            new MovieViewModel { Id = 7, Name = "The Witches", rating = "3", ReleaseYear = 2020, Genre = "Comedy", image = }
            new MovieViewModel { Id = 8, Name = "Love at First Sight", rating = "4", ReleaseYear = 2023, Genre = "Romance/Drama", image = }
            new MovieViewModel { Id = 9, Name = "Persuasion", rating = "2", ReleaseYear = 2022, Genre = "Romance/Drama", image = }
            new MovieViewModel { Id = 10, Name = "After We fell", rating = "3", ReleaseYear = 2021, Genre = "Romance/Drama", image = }
            new MovieViewModel { Id = 11, Name = "The Invitation", rating = "2", ReleaseYear = 2022, Genre = "Horror", image = }
            new MovieViewModel { Id = 12, Name = "Incantation", rating = "3", ReleaseYear = 2022, Genre = "Horror", image = }
            new MovieViewModel { Id = 13, Name = "True Beauty", rating = "4", ReleaseYear = 2020, Genre = "Romance/Drama", image = }
            new MovieViewModel { Id = 14, Name = "Train to Busan", rating = "5", ReleaseYear = 2016, Genre = "Horror", image = }
            new MovieViewModel { Id = 15, Name = "The 8th Night", rating = "3", ReleaseYear = 2021, Genre = "Horror", image = }
        }
    }

    public IActionResult Index()
    {
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

