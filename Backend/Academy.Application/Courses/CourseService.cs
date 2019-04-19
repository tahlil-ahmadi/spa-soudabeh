using System;
using System.Collections.Generic;
using System.Linq;
using Academy.DataAccess.EFCore;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;

namespace Academy.Application.Courses
{
    public class CourseService : ICourseService
    {
        private readonly AcademyDbContext _dbContext;
        public CourseService(AcademyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public DataSourceResult Get(DataSourceRequest request)
        {
            return _dbContext.Courses.AsQueryable().ToDataSourceResult(request);
        }
    }
}