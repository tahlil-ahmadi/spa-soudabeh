using System.Collections.Generic;

namespace Academy.Application
{
    public interface ICourseCategoryService
    {
        void Create(CreateCourseCategoryDto dto);
        List<CourseCategoryDto> GetAll();
        void Delete(long id);
        CourseCategoryDto GetById(long id);
        void Modify(ModifyCourseCategoryDto dto);
    }
}