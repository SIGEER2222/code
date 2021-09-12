using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFcore练习1.model
{
    public class IBookConfig : IEntityTypeConfiguration<Book>

    {
        //约定大于配置
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            throw new NotImplementedException();
            builder.ToTable("TBook");

        }
    }
}
