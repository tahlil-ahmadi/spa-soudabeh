﻿using System;
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
        [HttpGet]
        public List<CourseCategoryDto> Get()
        {
            //TODO: inject dependencies
            return new CourseCategoryService().GetAll();
        }
    }
}