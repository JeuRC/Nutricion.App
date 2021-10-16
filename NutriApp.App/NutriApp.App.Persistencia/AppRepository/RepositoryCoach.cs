using System.Collections.Generic;
using System.Linq;
using NutriApp.App.Dominio;

namespace NutriApp.App.Persistencia{
    public class RepositoryCoach : IRepositoryCoach{
        private readonly AppContext _appContext = new AppContext();

        Coach IRepositoryCoach.AddCoach(Coach coach){
            var coachAdicionado = _appContext.Coaches.Add(coach);
            _appContext.SaveChanges();
            return coachAdicionado.Entity;
        }
        
        void IRepositoryCoach.RemoveCoach(int idCoach){
            var coachEncontrado = _appContext.Coaches.FirstOrDefault(c=>c.Id == idCoach);
            if(coachEncontrado == null)return ;

            _appContext.Coaches.Remove(coachEncontrado);
            _appContext.SaveChanges();
        }

        Coach IRepositoryCoach.UpdateCoach(Coach coach){
            var coachEncontrado = _appContext.Coaches.FirstOrDefault(c=>c.Id == coach.Id);

            if(coachEncontrado != null){
                coachEncontrado.Nombre = coach.Nombre;
                coachEncontrado.FechaNacimiento = coach.FechaNacimiento;
                coachEncontrado.Telefono = coach.Telefono;
                coachEncontrado.Correo = coach.Correo;
                coachEncontrado.Password = coach.Password;
                coachEncontrado.Especializacion = coach.Especializacion;
                coachEncontrado.TarjetaProfesional = coach.TarjetaProfesional;
                _appContext.SaveChanges();
            }
                return coachEncontrado;
        }

        Coach IRepositoryCoach.GetCoach(int idCoach){
            return _appContext.Coaches.FirstOrDefault(c=>c.Id == idCoach);
        }

        IEnumerable<Coach> IRepositoryCoach.GetAllCoaches(){
            return _appContext.Coaches;
        }
        Coach IRepositoryCoach.LoginCoach(string email, string password){
            return _appContext.Coaches.FirstOrDefault(c=>c.Correo== email && c.Password == password);
        }
    }

}