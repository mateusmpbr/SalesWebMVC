using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class swmContext : DbContext
    {
        public swmContext (DbContextOptions<swmContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Department> Department { get; set; }
    }
}
