using NutriApp.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace NutriApp.App.Persistencia{

    public class AppContext:DbContext{
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Paciente> Pacientes {get;set;}
        public DbSet<Nutricionista> Nutricionistas {get;set;}
        public DbSet<Coach> Coaches {get;set;}
        public DbSet<Historial> Historiales {get;set;}
        public DbSet<Seguimiento> Seguimientos {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = NutriAppData");
            }
        }
    }
    
}