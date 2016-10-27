using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mmw.Web.Models
{
    /// <summary>
    /// 歌友等级
    /// 小将，高手，达人，大咖
    /// </summary>
    public class Grade
    {
        public int GradeId { get; set; }
        public string HonorName { get; set; }
        public string LogoPath { get; set; }
        public string Desc { get; set; }
    }
}