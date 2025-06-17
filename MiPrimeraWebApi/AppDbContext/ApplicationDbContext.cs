using Microsoft.EntityFrameworkCore;
using MiPrimeraWebApi.Models;

namespace MiPrimeraWebApi.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
