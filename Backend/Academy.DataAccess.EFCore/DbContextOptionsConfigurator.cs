using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Academy.DataAccess.EFCore
{
    //TODO: migrations not working right now, change this to IDesignTimeContextFactory
    public static class AcademyContextFactory
    {
        public static AcademyDbContext Create(string connectionString)
        {
            var options = new DbContextOptionsBuilder().UseSqlServer(connectionString).Options;
            return new AcademyDbContext(options);
        }
    }
}
