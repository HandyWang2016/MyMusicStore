using mmw.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mmw.Web
{
    /// <summary>
    /// 数据操作类
    /// </summary>
    public class MusicDbContext : DbContext
    {
        public MusicDbContext() : base("name=mmwDB")
        {
        }

        public DbSet<Singer> Singers { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Area> Areas { get; set; }
    }
}