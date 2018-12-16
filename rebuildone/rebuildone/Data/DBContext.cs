using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using rebuildone.Models;

namespace rebuildone.Data
{
  public class DbContext : IdentityDbContext<User>
  {
        public DbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<rebuildone.Models.User> User { get; set; }
        public DbSet<User> Password { get; set; }
    }
}