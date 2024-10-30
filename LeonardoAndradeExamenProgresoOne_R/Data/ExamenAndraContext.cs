using Microsoft.EntityFrameworkCore;

namespace LeonardoAndradeExamenProgresoOne_R.Data
{
    public class ExamenAndraContext : DbContext
    {
        public ExamenAndraContext(DbContextOptions<ExamenAndraContext> options)
            : base(options)
        {
        }

        public DbSet<LeonardoAndradeExamenProgresoOne_R.Models.Andrade> Andrades { get; set; } = default!;
        public DbSet<LeonardoAndradeExamenProgresoOne_R.Models.Celular> Celulars { get; set; } = default!;
        
    
    }
}
