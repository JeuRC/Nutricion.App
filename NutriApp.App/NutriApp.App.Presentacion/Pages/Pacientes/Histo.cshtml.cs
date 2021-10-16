using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriApp.App.Persistencia;
using NutriApp.App.Dominio;

namespace NutriApp.App.Presentacion.Page.Pacientes.Histo
{
    public class HistoModel : PageModel{   
        private readonly IRepositoryHistorial _repoHistorial;

        public IEnumerable<Historial> Historiales{get;set;}

        public HistoModel(IRepositoryHistorial _repoHistorial){
            this._repoHistorial = _repoHistorial;
        }

        public int idPaciente;

        public void OnGet(int id){
            idPaciente= id;
            Historiales = _repoHistorial.GetHistorialesByPaciente(id);            
        }
    }
}
