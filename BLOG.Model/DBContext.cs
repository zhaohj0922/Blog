using BLOG.Model.ArticleManager;
using BLOG.Model.Config;
using BLOG.Model.UserManager;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLOG.Model
{
    public class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext")
        {
        }
        public DbSet<Province> Province { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<Reward> Reward { get; set; }
        public DbSet<UserConfig> UserConfig { get; set; }
        public DbSet<ArticleType> ArticleType { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<KnowledgeType> KnowledgeType { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //移除自动建表时自动加上s的复数形式
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //移除一对多的级联删除约定
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //多对多启用级联删除约定
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
