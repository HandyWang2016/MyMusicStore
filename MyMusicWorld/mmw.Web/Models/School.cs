using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mmw.Web.Models
{
    /// <summary>
    /// 歌曲流派(抒情，民谣，乡村，劲爆..)
    /// </summary>
    public class School
    {
        public int SchoolId { get; set; }
        public string SchoolDesc { get; set; }

        //导航属性
        public virtual List<Song> Songs { get; set; }
    }
}