using webapi.event_.Domains;
using Microsoft.EntityFrameworkCore;

namespace webapi.event_.Contexts
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<PresencasEventos> PresencasEventos { get; set; }
        public DbSet<ComentariosEventos> ComentariosEventos { get; set; }
        public DbSet<Instituicoes> Instituicoes { get; set; }
        public DbSet<TiposUsuarios> TiposUsuarios { get; set; }
        public DbSet<TiposEventos> TiposEventos {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE39-S28\\SQLEXPRESS; Database=EventsPlus ; User ID=sa ; Password=Senai@134 ; TrustServerCertificate=true");
            }
        }
    }
}
