using Microsoft.EntityFrameworkCore;
using WEPAPPRAzor.Modelos;

namespace WEPAPPRAzor.Datos
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Curso> Cursos { get; set; }
    }
}
