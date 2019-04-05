using System;
using System.Collections.Generic;
using System.Text;
using Academy.Domain.IRepositories;
using Academy.Domain.Model;

namespace Academy.Persistence.Ef.Repositories
{
    public class CourseCategoryRepository:ICourseCategoryRepository
    {
        private readonly AcademyContext _context;
        public CourseCategoryRepository(AcademyContext context)
        {
            _context = context;
        }


        public void Add(CourseCategory courseCategory)
        {
            _context.CourseCategories.Add(courseCategory);
            _context.SaveChanges();
        }

    }
}
