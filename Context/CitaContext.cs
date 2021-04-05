using Tarea_9.Models;
using Microsoft.EntityFrameworkCore;

namespace Tarea_9.Context
{
    public class CitaContext : DbContext
    {
        public CitaContext(DbContextOptions<CitaContext> options)
            :base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Cita> Citas { get; set; }
    }
}