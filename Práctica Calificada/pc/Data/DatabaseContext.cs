using Microsoft.EntityFrameworkCore;
namespace pc.Data
{
    public class DatabaseContext : DbContext{
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
        : base(options) {  
        }
        public DbSet<pc.Models.Create> Creates {get; set;}
    }
}