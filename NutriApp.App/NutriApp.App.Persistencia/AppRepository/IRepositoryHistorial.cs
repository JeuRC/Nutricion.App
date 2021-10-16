using System.Collections.Generic;
using NutriApp.App.Dominio;

namespace NutriApp.App.Persistencia{
    public interface IRepositoryHistorial{
        IEnumerable<Historial> GetAllHistoriales();
        Historial AddHistorial(Historial historial);
        Historial UpdateHistorial(Historial historial);
        void RemoveHistorial(int idHistorial);
        Historial GetHistorial(int idHistorial);
        IEnumerable<Historial> GetHistorialesByPaciente(int idPaciente);
    }
}