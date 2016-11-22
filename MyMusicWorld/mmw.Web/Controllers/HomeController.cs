﻿using mmw.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var songs = context.Songs.ToList();
            StringBuilder songStr = new StringBuilder();

            foreach (var item in songs)
            {
                songStr.AppendFormat("\"test\":{0}",item.SongTitle);
                songStr.AppendFormat("{\"mp3\":\"{0}\"", item.Path);
                songStr.AppendFormat("\"title\":\"{0}\"}", item.SongTitle);


                songStr.AppendFormat("{\"mp3\":\"{0}\",\"title\":\"{1}\",\"artist\":\"{2}\"},", item.Path, item.SongTitle, item.Singer.SingerName);
            }

            songStr.Remove(songStr.Length - 1, 1).Insert(0, '[').Append(']');
            ViewBag.songs = songStr;

            return View();
        }
    }
}