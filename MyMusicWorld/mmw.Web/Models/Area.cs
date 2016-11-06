using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mmw.Web.Models
{
    /// <summary>
    /// 地区(港台，大陆，欧美，日韩)
    /// </summary>
    [Table("mmw_Area")]
    public class Area
    {
        [Key]
        public int AreaId { get; set; }
        public string AreaName { get; set; }

        //导航属性
        public virtual List<Singer> Singers { get; set; }
    }
}