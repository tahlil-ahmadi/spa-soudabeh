using System;
using System.Collections.Generic;

namespace Academy.Domain
{
    public class CourseCategory
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public CourseCategory ParentCategory { get; set; }
        public long? ParentCategoryId { get; set; }
    }
}
