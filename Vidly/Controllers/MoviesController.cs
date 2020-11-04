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
        public ActionResult Random()
        {
            var movie = new Movie(){Name = "Your first random movie"};
            //return View(movie);
            //return Content("Hello ASP.NET MVC 5!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index","Home", new {page = 1, sortBy = "name"});
            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;

            var Customers = new List<Customer>
            {
                new Customer{Name = "Customer A"},
                new Customer{Name = "Customer B"}
            };

            var ViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = Customers
            };
            
            return View(ViewModel);
            //return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " +  id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}