using System;
using System.Collections.Generic;
using System.Text;
using Academy.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.DataAccess.EFCore.Mapping
{
    public class CourseMapping : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.Instructor).IsRequired();
        }
    }
}
