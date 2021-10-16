using System.Collections.Generic;
using System.Linq;
using NutriApp.App.Dominio;

namespace NutriApp.App.Persistencia{
    public class RepositorySeguimiento : IRepositorySeguimiento{
        private readonly AppContext _appContext;
        public RepositorySeguimiento(AppContext appContext){
            _appContext=appContext;
        }

        Seguimiento IRepositorySeguimiento.AddSeguimiento(Seguimiento seguimiento){
            var seguimientoAdicionado = _appContext.Seguimientos.Add(seguimiento);
            _appContext.SaveChanges();
            return seguimientoAdicionado.Entity;
        }
        
        void IRepositorySeguimiento.RemoveSeguimiento(int idSeguimiento){
            var seguimientoEncontrado = _appContext.Seguimientos.FirstOrDefault(p=>p.Id == idSeguimiento);
            if(seguimientoEncontrado == null)return ;

            _appContext.Seguimientos.Remove(seguimientoEncontrado);
            _appContext.SaveChanges();

        }

        Seguimiento IRepositorySeguimiento.UpdateSeguimiento(Seguimiento seguimiento){
            var seguimientoEncontrado = _appContext.Seguimientos.FirstOrDefault(p=>p.Id == seguimiento.Id);

            if(seguimientoEncontrado != null){
                seguimientoEncontrado.Fecha = seguimiento.Fecha;
                seguimientoEncontrado.Descripcion = seguimiento.Descripcion;

                _appContext.SaveChanges();
            }
                return seguimientoEncontrado;
        }

        Seguimiento IRepositorySeguimiento.GetSeguimiento(int idSeguimiento){
            return _appContext.Seguimientos.FirstOrDefault(s=>s.Id == idSeguimiento);
        }

        IEnumerable<Seguimiento> IRepositorySeguimiento.GetAllSeguimientos(){
            return _appContext.Seguimientos;
        }
    }

}