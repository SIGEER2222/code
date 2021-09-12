using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFcore练习1.model
{
    public class MyDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuder)
            //指定连接哪个数据库
        {
            base.OnConfiguring(optionsBuder);
            optionsBuder.UseSqlServer("");
        }
        protected override void OnModelCreating(ModelBuilder modebuilder)
        {
            base.OnModelCreating(modebuilder);
            //从当前程序集加载所有的IEntityTypeConfiguration
            modebuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }

}
