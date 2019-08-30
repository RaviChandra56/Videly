using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Videly.Models;
using Videly.ViewModels;
using System.Data.Entity;

namespace Videly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(x => x.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(x => x.Genre).SingleOrDefault(x => x.Id == id);

            return View(movie);
        }

        // GET: Movies
        /// <summary>
        /// O/P's of an Action = View,PartialView, Json, Content, File, HttpNotFound, EmptyResult, RedirectToAction
        /// Using ViewData dictionary and ViewBag - needs to explicitly cast and this is bit ugly
        /// -- one more problem is Magic string (name of the viewdata or viewbag)
        /// ViewBag is dynamic property
        /// </summary>
        /// <returns></returns>
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Jason Bourne" };
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Home", "Index", new { page =1, sortby ="name"});

            var customers = new List<Customer>
            {
                new Customer{ Name="Customer1" },
                new Customer{ Name="Customer2" }
            };

            var randomMovieViewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(randomMovieViewModel);
        }

        /// <summary>
        /// Attribute routes are more powerful in custom routing and cleaner way of creating custom routes
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return View();
        }
    }
}