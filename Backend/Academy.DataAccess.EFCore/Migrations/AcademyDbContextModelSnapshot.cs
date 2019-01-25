﻿// <auto-generated />
using System;
using Academy.DataAccess.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Academy.DataAccess.EFCore.Migrations
{
    [DbContext(typeof(AcademyDbContext))]
    partial class AcademyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Academy.Domain.CourseCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ParentCategoryId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("CourseCategories");
                });

            modelBuilder.Entity("Academy.Domain.CourseCategory", b =>
                {
                    b.HasOne("Academy.Domain.CourseCategory", "ParentCategory")
                        .WithMany()
                        .HasForeignKey("ParentCategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
