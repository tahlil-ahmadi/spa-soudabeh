using System;
using System.Collections.Generic;
using System.Text;
using Academy.Application;
using Academy.DataAccess.EFCore;
using Autofac;

namespace Academy.Config
{
    public class AcademyModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CourseCategoryService>().As<ICourseCategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<AcademyDbContext>().InstancePerLifetimeScope();
        }
    }
}
