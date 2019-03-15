using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Academy.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Academy.Gateways.RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseCategoriesController : ControllerBase
    {
        private readonly ICourseCategoryService _service;
        private readonly ILogger<CourseCategoriesController> _logger;

        public CourseCategoriesController(ICourseCategoryService service,
                                          ILogger<CourseCategoriesController> logger)
        {
            _service = service;
            _logger = logger;
        }
        [HttpGet]
        public List<CourseCategoryDto> Get()
        {
            _logger.LogError("oh my god what a O_o");
            return _service.GetAll();
        }
        [HttpGet]
        [Route("{id}")]
        public CourseCategoryDto Get(long id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public void Post(CreateCourseCategoryDto dto)
        {
            _service.Create(dto);
            //TODO: return 201 instead
        }

        [HttpPut]
        [Route("{id}")]
        public void Put(long id, ModifyCourseCategoryDto dto)
        {
            dto.Id = id;
            _service.Modify(dto);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(long id)
        {
            _service.Delete(id);
            return NoContent();
        }
    }
}