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
        readonly MusicDbContext context = CurContext();

        // GET: Home
        public ActionResult Index()
        {
            var songs = context.Songs.ToList();
            StringBuilder songStr = new StringBuilder();
            foreach (var item in songs)
            {
                songStr.Append("{");
                songStr.AppendFormat("\"mp3\":\"{0}\",\"title\":\"{1}\",\"artist\":\"{2}\",\"duration\":\"3:50 \"", item.Path, item.SongTitle, item.Singer.SingerName);
                songStr.Append("},");
            }

            songStr.Remove(songStr.Length - 1, 1).Insert(0, '[').Append(']');
            ViewBag.songs = songStr.ToString();
            return View();
        }

        /// <summary>
        /// 音乐播放-single
        /// </summary>
        /// <returns></returns>
        public ActionResult Index_new()
        {
            return View();
        }

        /// <summary>
        /// 音乐播放-list
        /// </summary>
        /// <returns></returns>
        public ActionResult Index_List()
        {
            var songs = context.Songs.ToList();
            StringBuilder sonBuilder = new StringBuilder();
            foreach (var item in songs)
            {
                sonBuilder.Append("{");
                sonBuilder.AppendFormat("\"mp3\":\"{0}\",\"title\":\"{1}\",\"artist\":\"{2}\",\"free\":\"true\",\"SongId\":\"{3}\",\"Path\":\"{4}\",\"poster\":\"{5}\"",
                    item.Path, item.SongTitle, item.Singer.SingerName, item.SongId, item.Path, item.Singer.Photo);
                sonBuilder.Append("},");
            }

            sonBuilder.Remove(sonBuilder.Length - 1, 1).Insert(0, '[').Append(']');
            ViewBag.songs = sonBuilder.ToString();

            var singers = context.Singers.Where(item => !string.IsNullOrEmpty(item.Photo)).ToList();
            return View(singers);
        }
    }
}