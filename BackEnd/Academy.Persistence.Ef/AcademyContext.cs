using System;
using System.Collections.Generic;
using System.Text;
using Academy.Domain.Model;
using Academy.Persistence.Ef.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Academy.Persistence.Ef
{
    public class AcademyContext:DbContext
    {
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-M7N8K0R\MILAD;Initial Catalog=AcademyDB;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseCategoryMapping());
            modelBuilder.ApplyConfiguration(new CourseMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
