using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

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
            return RedirectToAction("Index","Home", new {page = 1, sortBy = "name"});
        }
    }
}