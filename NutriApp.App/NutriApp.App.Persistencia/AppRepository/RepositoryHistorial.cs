using System.Collections.Generic;
using System.Linq;
using NutriApp.App.Dominio;

namespace NutriApp.App.Persistencia{
    public class RepositoryHistorial : IRepositoryHistorial{
        private readonly AppContext _appContext = new AppContext();

        Historial IRepositoryHistorial.AddHistorial(Historial historial){
            var historialAdicionado = _appContext.Historiales.Add(historial);
            _appContext.SaveChanges();
            return historialAdicionado.Entity;
        }
        
        void IRepositoryHistorial.RemoveHistorial(int idHistorial){
            var historialEncontrado = _appContext.Historiales.FirstOrDefault(p=>p.Id == idHistorial);
            if(historialEncontrado == null)return ;
            
            _appContext.Historiales.Remove(historialEncontrado);
            _appContext.SaveChanges();

        }

        Historial IRepositoryHistorial.UpdateHistorial(Historial historial){
            var historialEncontrado = _appContext.Historiales.FirstOrDefault(p=>p.Id == historial.Id);

            if(historialEncontrado != null){
                historialEncontrado.Carbohidratos= historial.Carbohidratos;
                historialEncontrado.Proteinas = historial.Proteinas;
                historialEncontrado.Grasas = historial.Grasas;
                historialEncontrado.Peso = historial.Peso;
                historialEncontrado.Estatura = historial.Estatura;
                historialEncontrado.Seguimiento = historial.Seguimiento;

                _appContext.SaveChanges();
            }
                return historialEncontrado;
        }

        Historial IRepositoryHistorial.GetHistorial(int idHistorial){
            return _appContext.Historiales.FirstOrDefault(h=>h.Id == idHistorial);
        }

        IEnumerable<Historial> IRepositoryHistorial.GetAllHistoriales(){
            return _appContext.Historiales;
        }

        IEnumerable<Historial> IRepositoryHistorial.GetHistorialesByPaciente(int idPaciente){
            return _appContext.Historiales.Where(h=>h.PacienteId == idPaciente);
        }
    }

}