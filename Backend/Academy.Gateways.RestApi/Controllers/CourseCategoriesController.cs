using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academy.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Gateways.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController : ControllerBase
    {
        private readonly ICourseCategoryService _service;
        public CourseCategoriesController(ICourseCategoryService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<CourseCategoryDto> Get()
        {
            return _service.GetAll();
        }
    }
}