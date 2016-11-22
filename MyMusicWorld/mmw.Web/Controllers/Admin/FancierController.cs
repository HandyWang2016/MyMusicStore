using mmw.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mmw.Web.Controllers.Admin
{
    public class FancierController : BaseController
    {
        MusicDbContext context = CurContext();

        // GET: Fancier
        public ActionResult Index()
        {
            var fanciers = (from f in context.Fanciers
                            select f).ToList();
            var grades = (from g in context.Grades
                          select g).ToList();
            ViewBag.grades = grades;
            return View(fanciers);
        }

        public ActionResult Delete(int id)
        {
            var fancier = context.Fanciers.Find(id);
            if (fancier!=null)
            {
                context.Entry(fancier).State = EntityState.Deleted;
                context.Fanciers.Remove(fancier);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Add(Fancier fancier)
        {
            fancier.JoinTime = DateTime.Now;
            context.Fanciers.Add(fancier);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}