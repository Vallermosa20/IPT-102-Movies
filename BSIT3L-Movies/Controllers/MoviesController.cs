﻿using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<Movie> _movies;

        public MoviesController()
		{
            // Sample movie data
            _movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama" },
            new Movie { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller" },
            new Movie { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama" },
            new Movie { Id = 4, Name = "Nanny McPhee", Rating = "4", ReleaseYear = 2005, Genre = "Fantasy" },
            new Movie { Id = 5, Name = "Matilda", Rating = "4", ReleaseYear = 1996, Genre = "Fantasy" },
            new Movie { Id = 6, Name = "Luck", Rating = "4", ReleaseYear = 2002, Genre = "Comedy" },
            new Movie { Id = 7, Name = "The Witches", Rating = "3", ReleaseYear = 2020, Genre = "Comedy" },
            new Movie { Id = 8, Name = "Love at First Sight", Rating = "4", ReleaseYear = 2023, Genre = "Romance/Drama" },
            new Movie { Id = 9, Name = "Persuasion", Rating = "2", ReleaseYear = 2022, Genre = "Romance/Drama" },
            new Movie { Id = 10, Name = "After We fell", Rating = "3", ReleaseYear = 2021, Genre = "Romance/Drama" },
            new Movie { Id = 11, Name = "The Invitation", Rating = "2", ReleaseYear = 2022, Genre = "Horror" },
            new Movie { Id = 12, Name = "Incantation", Rating = "3", ReleaseYear = 2022, Genre = "Horror" },
            new Movie { Id = 13, Name = "True Beauty", Rating = "4", ReleaseYear = 2020, Genre = "Romance/Drama" },
            new Movie { Id = 14, Name = "Train to Busan", Rating = "5", ReleaseYear = 2016, Genre = "Horror" },
            new Movie { Id = 15, Name = "The 8th Night", Rating = "3", ReleaseYear = 2021, Genre = "Horror" },
            };
        }
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(movie => movie.Id == id);
            if (movie == null)
            return NotFound();
            return View(movie);
        }
    }
}

