using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModels;
using Vidly.DAL;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        public ActionResult Details(int id)
        {
            var movie = getMovies().SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        public ActionResult Index()
        {
            return View(getMovies());
        }

        public IEnumerable<Movie> getMovies()
        {
            return db.Movies.ToList();
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View("MovieForm", movie) ;
            }
            if (movie.Id == 0)
                db.Movies.Add(movie);
            else
            {
                var movieInDb = db.Movies.ToList().SingleOrDefault(c => c.Id ==  movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.Released = movie.Released;
                movieInDb.Genre = movie.Genre;
                movieInDb.inStock = movie.inStock;
                movieInDb.Added = movie.Added;
                //TryUpdateModel(customerInDb);
            }
            db.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        [Route("movies/released/{year:range(1900,2020)}/{month:range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit(int id)
        {
            var movie = db.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View("MovieForm", movie);
        }

        public ActionResult New()
        {
            Movie m = new Movie();
            m.Id = 0;
            return View("MovieForm", m);
        }

    }
}