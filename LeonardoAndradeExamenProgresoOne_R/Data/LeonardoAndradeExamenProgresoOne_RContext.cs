using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeonardoAndradeExamenProgresoOne_R.Models;

namespace LeonardoAndradeExamenProgresoOne_R.Data
{
    public class LeonardoAndradeExamenProgresoOne_RContext : DbContext
    {
        public LeonardoAndradeExamenProgresoOne_RContext (DbContextOptions<LeonardoAndradeExamenProgresoOne_RContext> options)
            : base(options)
        {
        }

        public DbSet<LeonardoAndradeExamenProgresoOne_R.Models.Andrade> Andrade { get; set; } = default!;
        public DbSet<LeonardoAndradeExamenProgresoOne_R.Models.Celular> Celular { get; set; } = default!;
    }
}
