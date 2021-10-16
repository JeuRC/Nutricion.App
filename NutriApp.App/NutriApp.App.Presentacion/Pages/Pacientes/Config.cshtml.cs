using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriApp.App.Persistencia;
using NutriApp.App.Dominio;

namespace NutriApp.App.Presentacion.Page.Pacientes.Config
{
    public class ConfigModel : PageModel
    {
        private readonly IRepositoryPaciente _repoPaciente;
        public ConfigModel(IRepositoryPaciente _repoPaciente){
            this._repoPaciente = _repoPaciente;
        }

        [BindProperty]
        public Paciente Paciente {get;set;}
        private Paciente PacienteEdit;
        
        public void OnGet(int id)
        {
            Paciente = _repoPaciente.GetPaciente(id);
        }

        public IActionResult OnPostEdit(){
            PacienteEdit = _repoPaciente.UpdatePaciente(Paciente);
            if(PacienteEdit != null){
                return RedirectToPage("./index", new { id = PacienteEdit.Id});
            }else{
                return Page();
            }
        }
    }
}
