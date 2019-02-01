using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Academy.DataAccess.EFCore;
using Academy.Domain;
using Mapster;

namespace Academy.Application
{
    public class CourseCategoryService
    {
        public void Create(CreateCourseCategoryDto dto)
        {
            using (var context = new AcademyDbContext())
            {
                var entity = new CourseCategory()
                {
                    ParentCategoryId = dto.ParentId,
                    Title = dto.Title
                };
                context.CourseCategories.Add(entity);
                context.SaveChanges();
            }
        }
        public List<CourseCategoryDto> GetAll()
        {
            using (var context = new AcademyDbContext())
            {
                //TODO: whole tree is loading, make it lazy
                var entities = context.CourseCategories.ToList()
                                .Where(a=>a.ParentCategoryId == null)
                                .ToList();
                return entities.Adapt<List<CourseCategoryDto>>();
            }
        }
    }
}
