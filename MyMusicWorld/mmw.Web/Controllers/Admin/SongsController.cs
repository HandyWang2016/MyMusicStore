using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mmw.Web.Controllers.Admin
{
    public class SongsController : BaseController
    {
        MusicDbContext context = CurContext();

        // GET: Songs
        public ActionResult Index()
        {
            //var songs = context.Songs.ToList();

            return View();
        }
    }
}