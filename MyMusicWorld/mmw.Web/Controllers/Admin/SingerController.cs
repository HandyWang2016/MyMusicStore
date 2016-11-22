using mmw.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mmw.Web.Controllers.Admin
{
    public class SingerController : BaseController
    {
        //当前上下文
        MusicDbContext context = CurContext();

        // GET: Singer
        public ActionResult Index()
        {
            var areas = context.Areas.ToList();
            var singers = context.Singers.ToList();
            ViewBag.Areas = areas;
            return View(singers);
        }

        [HttpPost]
        public ActionResult Add(Singer singer)
        {
            context.Singers.Add(singer);
            var result = context.SaveChanges();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 删除歌手信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            var singer = context.Singers.Find(id);
            if (singer!=null)
            {
                context.Entry(singer).State = EntityState.Deleted;
                context.Singers.Remove(singer);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}