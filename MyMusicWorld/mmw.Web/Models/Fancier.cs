using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mmw.Web.Models
{
    /// <summary>
    /// 发烧友
    /// </summary>
    [Table("mmw_Fancier")]
    public class Fancier
    {
        [Key]
        public int FancierId { get; set; }
        public string FancierName { get; set; }
        public List<Song> FavoriteSongs { get; set; }
        public int GradeId { get; set; }
        public DateTime JoinTime { get; set; }

        public virtual Grade Grade { get; set; }
    }
}