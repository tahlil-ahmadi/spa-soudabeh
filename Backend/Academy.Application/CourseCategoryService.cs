using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Academy.DataAccess.EFCore;
using Academy.Domain;
using Mapster;

namespace Academy.Application
{
    public class CourseCategoryService : ICourseCategoryService
    {
        private readonly AcademyDbContext _dbContext;
        public CourseCategoryService(AcademyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(CreateCourseCategoryDto dto)
        {
            var entity = new CourseCategory()
            {
                ParentCategoryId = dto.ParentId,
                Title = dto.Title
            };
            _dbContext.CourseCategories.Add(entity);
            _dbContext.SaveChanges();
        }
        public List<CourseCategoryDto> GetAll()
        {
            //TODO: whole tree is loading, make it lazy
            var entities = _dbContext.CourseCategories.ToList()
                            .Where(a=>a.ParentCategoryId == null)
                            .ToList();
            return entities.Adapt<List<CourseCategoryDto>>();
        }
    }
}
