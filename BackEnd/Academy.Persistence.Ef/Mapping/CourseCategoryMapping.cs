using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Academy.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Persistence.Ef.Mapping
{
    public class CourseCategoryMapping:IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.ToTable("CourseCategories").HasKey(a=>a.Id);
            builder.HasOne(x => x.ParentCategory).WithMany();
            builder.Property(x => x.Title).HasMaxLength(300).IsRequired();
        }
    }
}
