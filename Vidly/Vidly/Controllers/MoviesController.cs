using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            //if (!pageIndex.HasValue)
            //pageIndex = 1;

            //if (String.IsNullOrWhiteSpace(sortBy))
            //sortBy = "Name";

            // pageindex 1st parameter, sortBy 2nd parameter
            //return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Pets" },
                new Movie { Id = 2, Name = "Whiplash" }
            };

            var viewModel = new MovieListViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Movie Name" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            // Add the movie param to render the object
            return View(viewModel);
        }

        // GET: Movies/Edit
        public ActionResult Edit(int movieId)
        {
            return Content("id = " + movieId);
        }

        // GET: Movies/released/1/2
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}