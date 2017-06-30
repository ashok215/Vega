using Microsoft.EntityFrameworkCore;
using Vega.Models;

namespace vega.Persistence
{
    public class VegaDbcontext:DbContext
    {
        public VegaDbcontext(DbContextOptions<VegaDbcontext> options) 
          : base(options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}