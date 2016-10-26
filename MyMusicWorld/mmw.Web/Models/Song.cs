using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mmw.Web.Models
{
    /// <summary>
    /// 歌曲信息
    /// </summary>
    public class Song
    {
        public int SongId { get; set; }
        public int SongTitle { get; set; }
        public DateTime CreateTime { get; set; }
        public string Path { get; set; }
        public int PlayTimes { get; set; }
        public int PraiseTimes { get; set; }
        //外键
        public int SingerId { get; set; }
        public int SchoolId { get; set; }
        //导航属性
        public Singer Singer { get; set; }
        public School School { get; set; }

    }
}