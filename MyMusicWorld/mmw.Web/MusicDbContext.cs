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
        public virtual DbSet<Singer> Singers { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Fancier> Fanciers { get; set; }
        public virtual DbSet<Grade> Grades { get; set; }

        public MusicDbContext() : base("name=mmwDB")
        {
            Database.SetInitializer<MusicDbContext>(new MyCreateDatabaseIfNotExists());
        }   
    }

    /// <summary>
    /// 定义种子数据
    /// </summary>
    public class MyCreateDatabaseIfNotExists : CreateDatabaseIfNotExists<MusicDbContext>
    {
        protected override void Seed(MusicDbContext context)
        {
            Area area = new Area()
            {
                AreaId = 1,
                AreaName = "大陆",
            };
            Singer singer = new Singer()
            {
                SingerId = 1,
                Sex = 1,
                SingerName = "刘德华",
                Area=area
            };

            School school = new School()
            {
                SchoolId = 1,
                SchoolDesc = "流行"
            };

            Grade grade = new Grade()
            {
                GradeId = 1,
                HonorName = "小将",
                LogoPath = "/",
                Desc = "注册成为网站会员即为'小将'"
            };

            Fancier fancier = new Fancier()
            {
                FancierId = 1,
                FancierName = "Jack",
                JoinTime = DateTime.Now,
                Grade=grade
            };

            Song song = new Song()
            {
                SongId = 1,
                SongTitle = "练习",
                Path = "/",
                CreateTime = DateTime.Now,
                PlayTimes = 0,
                PraiseTimes = 0,
                Singer=singer,
                School=school,
                Fancier=fancier
            };

            context.Areas.Add(area);
            context.Singers.Add(singer);
            context.Songs.Add(song);
            context.Schools.Add(school);
            context.Fanciers.Add(fancier);
            context.Grades.Add(grade);

            base.Seed(context);
        }
    }
}