using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mmw.Web.Models
{
    /// <summary>
    /// 歌曲流派(抒情，民谣，乡村，劲爆..)
    /// </summary>
    [Table("mmw_School")]
    public class School
    {
        [Key]
        public int SchoolId { get; set; }
        public string SchoolDesc { get; set; }

        //导航属性
        public virtual List<Song> Songs { get; set; }
    }
}