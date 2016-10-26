using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mmw.Web.Models
{
    /// <summary>
    /// 歌手信息
    /// </summary>
    public class Singer
    {
        public int SingerId { get; set; }
        public string SingerName { get; set; }
        /// <summary>
        /// 1男 2女
        /// </summary>
        public int Sex { get; set; }

        //外键
        public int AreaId { get; set; }
        //导航属性
        public List<Song> Songs { get; set; }
        public Area Area { get; set; }



    }
}