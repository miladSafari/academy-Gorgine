using System;
using System.Collections.Generic;
using System.Text;
using Academy.Domain.IRepositories;
using Academy.Domain.Model;

namespace Academy.Application.Services
{
    public class CourseCategoryService : ICourseCategoryService
    {
        private readonly ICourseCategoryRepository _repository;
        public CourseCategoryService(ICourseCategoryRepository repository)
        {
            this._repository = repository;
        }
        public void Create(string str)
        {
            //ICourseCategoryRepository repository = null;
            var courseCategory = new CourseCategory()
            {
                Title = str
            };
            _repository.Add(courseCategory);
        }
    }
}
