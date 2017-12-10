using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace RacquetSwingers.Entities
{
    public class TemporaryDbContextFactory : IDesignTimeDbContextFactory<IdentityFrameworkContext>
    {
        public TemporaryDbContextFactory()
        {
        }

        public IdentityFrameworkContext Create(DbContextFactoryOptions options)
            {
                //var builder = new DbContextOptionsBuilder<IdentityFrameworkContext>();
                var builder = new DbContextOptionsBuilder<IdentityFrameworkContext>();
                builder.UseSqlServer("Server=nezaci-instance1.cet70jrbcw1r.us-west-2.rds.amazonaws.com; Database=RacquetSwingers; User Id=NeZaCIAdmin; Password=Zac10172009; MultipleActiveResultSets=true",
                    optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(IdentityFrameworkContext).GetTypeInfo().Assembly.GetName().Name));
                return new IdentityFrameworkContext(builder.Options);
            }
    }
}
