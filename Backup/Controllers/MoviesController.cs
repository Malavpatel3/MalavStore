using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental1.Models;

namespace RandomMovieViewModel.MovieRental1.Controllers
{
    //Get : Movie/Random
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie() { Name = " Titanic" };
            var customers = new List<Customer>
            {
                new Customer { Name = " Customer 1"},
                new Customer { Name = " Customer 2"}

            };
            var viewModel = new RandomMovieViewModel
            {

                movie = movie,
                Customers = customers
            };

            return View(viewModel);
                


            var viewResult = new ViewResult();

            viewResult.ViewData.Model;

                      return View(movie); 
                      

        }
        public ActionResult Edit(int id)

        {
            return Content("id=" + id);
        }
        //movies
        public ActionResult Index(int? pageIndex, String sorttBy)
        {

            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sorttBy))
                sorttBy = " Name";

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sorttBy));
        }
        [Route ("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {

            return Content(year + "/" + month);
        }
    }
}
   