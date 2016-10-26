using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mmw.Web.Models
{
    /// <summary>
    /// 地区(港台，大陆，欧美，日韩)
    /// </summary>
    public class Area
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }

        //导航属性
        public List<Singer> Singers { get; set; }
    }
}