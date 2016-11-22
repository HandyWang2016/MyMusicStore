using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mmw.Web.Controllers.Admin
{
    public class Admin_HomeController : BaseController
    {
        MusicDbContext context = CurContext();

        // GET: Admin_Home
        public ActionResult Index()
        {
            return View();
        }
    }
}