using System.Collections.Generic;
using NutriApp.App.Dominio;

namespace NutriApp.App.Persistencia{
    public interface IRepositoryCoach{
        IEnumerable<Coach> GetAllCoaches();
        Coach AddCoach(Coach coach);
        Coach UpdateCoach(Coach coach);
        void RemoveCoach(int idCoach);
        Coach GetCoach(int idCoach);
        Coach LoginCoach(string email,string Password);
    }
}