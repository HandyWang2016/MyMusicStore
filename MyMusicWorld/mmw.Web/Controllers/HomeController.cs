﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mmw.Web.Controllers
{
    public class HomeController : Controller
    {
        MusicDbContext db = new MusicDbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}