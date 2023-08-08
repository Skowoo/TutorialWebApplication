using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TutorialWebApplication.Models;

namespace TutorialWebApplication.Data
{
    public class TutorialWebApplicationContext : DbContext
    {
        public TutorialWebApplicationContext (DbContextOptions<TutorialWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<TutorialWebApplication.Models.Movie> Movie { get; set; } = default!;
    }
}
