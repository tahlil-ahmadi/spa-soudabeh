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
        public AcademyDbContext(DbContextOptions options): base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
