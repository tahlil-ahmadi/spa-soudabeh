using System;
using System.Collections.Generic;
using System.Text;
using Academy.DataAccess.EFCore;
using Academy.Domain;

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
    }
}
