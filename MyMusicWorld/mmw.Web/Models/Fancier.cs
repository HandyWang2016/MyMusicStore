using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mmw.Web.Models
{
    /// <summary>
    /// 发烧友
    /// </summary>
    public class Fancier
    {
        public int FancierId { get; set; }
        public string FancierName { get; set; }
        public List<Song> FavoriteSongs { get; set; }
        public int GradeId { get; set; }
        public DateTime JoinTime { get; set; }

        public virtual Grade Grade { get; set; }
    }
}