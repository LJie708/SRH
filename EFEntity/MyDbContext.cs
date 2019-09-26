using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFEntity
{
    public class MyDbContext:DbContext
    {
        public MyDbContext():base("sql")
        {
            Database.SetInitializer<MyDbContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        //实体对象
        public DbSet<config_major> config_major { get; set; }
        public DbSet<config_major_kind> config_major_kind { get; set; }
        public DbSet<config_public_char> config_public_char { get; set; }
    }
}
