using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dollop.Models;

namespace Dollop.Api.Data
{
    public class CoreContext : DbContext
    {
        public CoreContext (DbContextOptions<CoreContext> options)
            : base(options)
        {
        }

        public DbSet<Dollop.Models.User> User { get; set; }

        public DbSet<Dollop.Models.Media> Media { get; set; }
    }
}
