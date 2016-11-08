using mmw.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mmw.Web.Controllers
{
    public class HomeController : BaseController
    {
        //获取数据操作对象
        MusicDbContext context = CurContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}