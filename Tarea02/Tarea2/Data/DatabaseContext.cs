using Microsoft.EntityFrameworkCore;

//dotnet add package Microsoft.EntityFrameworkCore --version 3.1.4
namespace demomvc.Data
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<demomvc.Models.Contacto> Contactos { get; set; }

    }

}