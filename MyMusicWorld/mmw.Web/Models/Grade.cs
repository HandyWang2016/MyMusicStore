using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mmw.Web.Models
{
    /// <summary>
    /// 歌友等级
    /// 小将，高手，达人，大咖
    /// </summary>
    [Table("mmw_Grade")]
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public string HonorName { get; set; }
        public string LogoPath { get; set; }
        public string Desc { get; set; }
    }
}