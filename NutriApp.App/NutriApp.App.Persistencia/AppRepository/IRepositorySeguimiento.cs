using System.Collections.Generic;
using NutriApp.App.Dominio;
 
namespace NutriApp.App.Persistencia{
    public interface IRepositorySeguimiento{
        IEnumerable<Seguimiento> GetAllSeguimientos();
        Seguimiento AddSeguimiento(Seguimiento seguimiento);
        Seguimiento UpdateSeguimiento(Seguimiento seguimiento);
        void RemoveSeguimiento(int idSeguimiento);
        Seguimiento GetSeguimiento(int idSeguimiento);
    }
}