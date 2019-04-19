using System;
using System.Collections.Generic;
using System.Text;
using Academy.Application;
using Academy.Application.Courses;
using Academy.DataAccess.EFCore;
using Autofac;

namespace Academy.Config
{
    public class AcademyModule : Module
    {
        private readonly string _connectionString;
        public AcademyModule(string connectionString)
        {
            _connectionString = connectionString;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseCategoryService>().As<ICourseCategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<CourseService>().As<ICourseService>().InstancePerLifetimeScope();

            builder.Register(a => AcademyContextFactory.Create(_connectionString)).InstancePerLifetimeScope();
        }
    }
}
