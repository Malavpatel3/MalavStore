using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRental1.Models;


namespace MovieRental1.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }
    }
}
