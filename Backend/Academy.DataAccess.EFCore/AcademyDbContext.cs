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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: remove this hard-coded connection string
            optionsBuilder.UseSqlServer(@"data source=CLASS1\MSSQLSERVER1;initial catalog=AcademySoudabeh;User Id=sa;password=123");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
