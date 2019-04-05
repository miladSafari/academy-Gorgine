using System;
using System.Collections.Generic;
using System.Text;
using Academy.Application.Services;
using Academy.Domain.IRepositories;
using Academy.Persistence.Ef;
using Academy.Persistence.Ef.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Academy.Config
{
    public static class AcademyBootstrapper
    {

        public static void WireUp(IServiceCollection services)
        {
            services.AddSingleton<ICourseCategoryRepository, CourseCategoryRepository>();
            services.AddSingleton<ICourseCategoryService, CourseCategoryService>();
            services.AddSingleton<AcademyContext>();
        }

    }
}
