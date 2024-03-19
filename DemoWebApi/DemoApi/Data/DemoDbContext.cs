using DemoApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.Data
{
    public class DemoDbContext: DbContext
    {
        public DemoDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { 
            

        }

        public DbSet<Product> Products { get; set; }
    }
}
