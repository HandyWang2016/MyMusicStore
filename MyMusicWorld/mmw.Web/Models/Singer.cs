using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mmw.Web.Models
{
    /// <summary>
    /// 歌手信息
    /// </summary>
    [Table("mmw_Singer")]
    public class Singer
    {
        [Key]
        public int SingerId { get; set; }
        public string SingerName { get; set; }
        /// <summary>
        /// 1男 2女
        /// </summary>
        public int Sex { get; set; }

        //外键
        public int AreaId { get; set; }
        //导航属性
        public virtual List<Song> Songs { get; set; }
        public virtual Area Area { get; set; }



    }
}