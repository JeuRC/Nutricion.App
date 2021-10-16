using System.Collections.Generic;
using NutriApp.App.Dominio;

namespace NutriApp.App.Persistencia{
    public interface IRepositoryNutricionista{
        IEnumerable<Nutricionista> GetAllNutricionistas();
        Nutricionista AddNutricionista(Nutricionista nutricionista);
        Nutricionista UpdateNutricionista(Nutricionista nutricionista);
        void RemoveNutricionista(int idNutricionista);
        Nutricionista GetNutricionista(int idNutricionista);
        Nutricionista LoginNutricionista(string email, string password);
    }
}