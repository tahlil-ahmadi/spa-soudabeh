namespace Academy.Application
{
    public class CourseCategoryDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long? ParentId { get; set; }
    }
}