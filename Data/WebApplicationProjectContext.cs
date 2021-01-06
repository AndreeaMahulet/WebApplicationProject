using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationProject.Models;

namespace WebApplicationProject.Data
{
    public class WebApplicationProjectContext : DbContext
    {
        public WebApplicationProjectContext (DbContextOptions<WebApplicationProjectContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationProject.Models.Student> Student { get; set; }

        public DbSet<WebApplicationProject.Models.Course> Course { get; set; }

        public DbSet<WebApplicationProject.Models.Class> Class { get; set; }

        public DbSet<WebApplicationProject.Models.Teacher> Teacher { get; set; }
    }
}
