using System;
using System.Collections.Generic;
using System.Text;
using Academy.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.DataAccess.EFCore.Mapping
{
    public class CourseCategoryMapping : IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.ToTable("CourseCategories");
            builder.Property(a => a.Title).HasMaxLength(250).IsRequired();
            builder.HasOne(a => a.ParentCategory)
                   .WithMany(a=>a.Children)
                   .HasForeignKey(a => a.ParentCategoryId);
        }
    }
}
