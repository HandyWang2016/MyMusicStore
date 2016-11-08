using mmw.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mmw.Web.Controllers.Admin
{
    public class AreaController : BaseController
    {
        MusicDbContext context = CurContext();

        // GET: Area
        public ActionResult Index()
        {
            var areas = context.Areas.ToList();
            return View(areas);
        }

        /// <summary>
        /// 删除区域
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            Area area = context.Areas.Find(id);
            if (area!=null)
            {
                context.Entry(area).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 添加新地区信息
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(string AreaName)
        {
            context.Areas.Add(new Area { AreaName = AreaName });
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}