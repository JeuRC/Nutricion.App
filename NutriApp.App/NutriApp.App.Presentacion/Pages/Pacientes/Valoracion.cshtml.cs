using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriApp.App.Persistencia;
using NutriApp.App.Dominio;

namespace NutriApp.App.Presentacion.Page.Pacientes.Valoracion
{
    public class ValoracionModel : PageModel
    {
        private readonly IRepositoryHistorial _repoHistorial;

        public ValoracionModel(IRepositoryHistorial _repoHistorial){
            this._repoHistorial = _repoHistorial;
        }

        [BindProperty]
        public Historial Historial{set;get;}
        [BindProperty]
        public int idPaciente{set;get;}
        public void OnGet(int id){
            idPaciente = id;
        }

        public IActionResult OnPost(){
            var HistorialResult = _repoHistorial.AddHistorial(Historial);
            if (HistorialResult != null){
                return RedirectToPage("./Histo",new { id = Historial.PacienteId});
            }else{
                return Page();
            }
        }
    }
}
