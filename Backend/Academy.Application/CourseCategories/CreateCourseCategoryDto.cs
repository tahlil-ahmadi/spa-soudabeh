namespace Academy.Application
{
    public class CreateCourseCategoryDto
    {
        public string Title { get; set; }
        public long? ParentId { get; set; }
    }
}