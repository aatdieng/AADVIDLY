﻿using System;
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
        // GET: Movies/Random
        public ActionResult Random()

        {
            var movie = new Movie() { Name = "Konte Khassaw" };

          
            var customers = new List<Customer>
            {
                new Customer { Name = "Alassane" },
                new Customer { Name = "Moundiaye" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
        
            return View(viewModel);
                       
        }


        //[Route("movies/release/{year}/{month : regex(\\d{2}):range(1 , 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

    }
}