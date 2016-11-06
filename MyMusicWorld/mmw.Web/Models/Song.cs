using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mmw.Web.Models
{
    /// <summary>
    /// 歌曲信息
    /// </summary>
    [Table("mmw_Songs")]
    public class Song
    {
        [Key]
        public int SongId { get; set; }
        [Column("SongTitle"),StringLength(20)]
        public string SongTitle { get; set; }
        public DateTime CreateTime { get; set; }
        public string Path { get; set; }
        public int PlayTimes { get; set; }
        public int PraiseTimes { get; set; }
        //外键
        public int SingerId { get; set; }
        public int SchoolId { get; set; }
        public int FancierId { get; set; }
        //导航属性
        public virtual Singer Singer { get; set; }
        public virtual School School { get; set; }
        public virtual Fancier Fancier { get; set; }

    }
}