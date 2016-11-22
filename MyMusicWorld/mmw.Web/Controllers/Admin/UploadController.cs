using mmw.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mmw.Web.Controllers.Admin
{
    public class UploadController : BaseController
    {
        MusicDbContext context = CurContext();

        // GET: Upload
        public ActionResult Index()
        {
            var schools = context.Schools.ToList();
            var singers = context.Singers.ToList();
            var fanciers = context.Fanciers.ToList();

            ViewBag.schools = schools;
            ViewBag.singers = singers;
            ViewBag.fanciers = fanciers;
            return View();
        }

        [HttpPost]
        public ActionResult Add(Song song)
        {
            song.CreateTime = DateTime.Now;
            context.Songs.Add(song);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// 文件上传
        /// </summary>
        /// <returns></returns>
        public ActionResult Upload()
        {
            HttpFileCollection files = System.Web.HttpContext.Current.Request.Files;
            string filePath = string.Empty;
            if (files.Count > 0)
            {
                filePath = "/Songs/" + files[0].FileName;
                string physicalPath = Server.MapPath(filePath);
                files[0].SaveAs(physicalPath);
            }

            return Json(new { msg = "上传成功", filePath = filePath }, JsonRequestBehavior.AllowGet);
        }
    }
}