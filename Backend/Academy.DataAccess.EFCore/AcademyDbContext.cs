using System;
using System.Collections.Generic;
using System.Text;
using Academy.DataAccess.EFCore.Mapping;
using Academy.Domain;
using Microsoft.EntityFrameworkCore;

namespace Academy.DataAccess.EFCore
{
    public class AcademyDbContext : DbContext
    {
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public AcademyDbContext(DbContextOptions options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseMapping());
            modelBuilder.ApplyConfiguration(new CourseCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
