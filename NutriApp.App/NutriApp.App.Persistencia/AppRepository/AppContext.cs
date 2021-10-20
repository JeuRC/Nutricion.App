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
                .UseSqlServer("Server=tcp:databasenutri-app.database.windows.net,1433;Initial Catalog=NutriApp;Persist Security Info=False;User ID=FullDev;Password=nutriapp1234*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
    
}