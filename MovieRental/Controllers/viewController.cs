﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRental1.Controllers
{
    public class viewController : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
    }
}