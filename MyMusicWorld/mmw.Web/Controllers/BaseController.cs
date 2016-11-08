using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mmw.Web.Controllers
{
    public class BaseController : Controller
    {
        //类似单例的方式获取数据操作对象
        private static MusicDbContext _context;
        public static MusicDbContext CurContext()
        {
            if (_context == null)
            {
                return new MusicDbContext();
            }
            return _context;
        }
    }
}