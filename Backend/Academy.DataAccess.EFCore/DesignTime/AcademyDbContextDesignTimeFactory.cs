using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Academy.DataAccess.EFCore.DesignTime
{
    public class AcademyDbContextDesignTimeFactory : IDesignTimeDbContextFactory<AcademyDbContext>
    {
        public AcademyDbContext CreateDbContext(string[] args)
        {
            //TODO: remove hard coded connection string
            var options = new DbContextOptionsBuilder()
                .UseSqlServer("data source=CLASS1\\MSSQLSERVER1;initial catalog=AcademySoudabeh;User Id=sa;password=123")
                .Options;
            return new AcademyDbContext(options);
        }
    }
}
