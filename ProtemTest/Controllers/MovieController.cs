using ProtemTest.Models;
using ProtemTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProtemTest.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1" },
                new Customer {Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        // GET: Movie/Index
        public ActionResult Index()
        {
            var movie = GetMovies();
            return View(movie);
        }

        //returns list of movies
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie() { id=1, Name="Shrek" },
                new Movie() { id=2, Name="Wall-e" }
            };
        }
    }
}