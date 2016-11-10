using mmw.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mmw.Web.Controllers.Admin
{
    /// <summary>
    /// 流派
    /// </summary>
    public class SchoolController : BaseController
    {
        MusicDbContext context = CurContext();

        // GET: School
        public ActionResult Index()
        {
            var schools = context.Schools.ToList();
            return View(schools);
        }

        /// <summary>
        /// 新增流派
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(string SchoolDesc)
        {
            context.Schools.Add(new School() { SchoolDesc = SchoolDesc });
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 删除流派
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            School school = context.Schools.Find(id);
            if (school!=null)
            {
                context.Entry(school).State = EntityState.Deleted;
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}