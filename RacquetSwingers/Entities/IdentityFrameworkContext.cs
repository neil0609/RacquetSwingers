using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RacquetSwingers.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RacquetSwingers.Entities
{
    public class IdentityFrameworkContext : IdentityDbContext<User>
    {
        public IdentityFrameworkContext(DbContextOptions<IdentityFrameworkContext> options) : base(options)
        {

        }
    }
}
