using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Academy.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Persistence.Ef.Mapping
{
    public class CourseMapping:IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses").HasKey(a=>a.Id);
            builder.HasOne(x => x.Category).WithMany();
            builder.Property(x => x.Title).HasMaxLength(300).IsRequired();
        }
    }
}
