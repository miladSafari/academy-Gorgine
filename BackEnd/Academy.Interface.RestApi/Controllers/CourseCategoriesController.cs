using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Interface.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController : ControllerBase
    {
        public void Post()
        {
            var service = new CourseCategoryService();
            service.Create("Web API");
        }
    }
}
