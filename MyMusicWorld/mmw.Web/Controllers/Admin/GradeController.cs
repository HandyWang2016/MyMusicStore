using mmw.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mmw.Web.Controllers.Admin
{
    public class GradeController : BaseController
    {
        MusicDbContext context = CurContext();

        // GET: Grade
        public ActionResult Index()
        {
            List<Grade> grades = context.Grades.ToList();
            return View(grades);
        }

        /// <summary>
        /// 新增等级
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create()
        {
            Grade grade = new Grade();
            TryUpdateModel(grade);
            context.Grades.Add(grade);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        /// <summary>
        /// 删除等级
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Delete(int id)
        {
            Grade grade = context.Grades.Find(id);
            if (grade != null)
            {
                context.Entry(grade).State = EntityState.Deleted;
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}