using Microsoft.EntityFrameworkCore;
using DRF.Models;

namespace DRF.Persistance
{
    public class DRFDbContext : DbContext
    {
        public DRFDbContext(DbContextOptions<DRFDbContext> options) : base(options)
        {
            
        }
        
        public DbSet<Make> Makes { get; set; }

    }
}