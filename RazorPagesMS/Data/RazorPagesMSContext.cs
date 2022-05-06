#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMS.Models;

namespace RazorPagesMS.Data
{
    public class RazorPagesMSContext : DbContext
    {
        public RazorPagesMSContext (DbContextOptions<RazorPagesMSContext> options)
            : base(options)
        {
        }
  
        public DbSet<RazorPagesMS.Models.Movie> Movie { get; set; }
    }
}
