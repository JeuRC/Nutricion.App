using Microsoft.EntityFrameworkCore;
using Nutricion.App.Dominio;

namespace Nutricion.App.Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Paciente> Pacientes {get;set;}
        public DbSet<Nutricionista> Nutricionistas {get;set;}
        public DbSet<Coach> Coach {get;set;}
        public DbSet<SugerenciaCuidado> SugerenciasCuidados {get;set;}
        public DbSet<Valoracion> Valoraciones {get;set;}
        public DbSet<Historia> Historias {get;set;}

        //"optionsBuilder" es como "conexion" en Java, se puede llamar de cualquier forma
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                ("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Nutricion");
            }
        }
    }
}