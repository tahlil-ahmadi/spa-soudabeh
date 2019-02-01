using System.Collections.Generic;

namespace Academy.Application
{
    public interface ICourseCategoryService
    {
        void Create(CreateCourseCategoryDto dto);
        List<CourseCategoryDto> GetAll();
    }
}