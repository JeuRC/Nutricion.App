using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriApp.App.Persistencia;
using NutriApp.App.Dominio;

namespace NutriApp.App.Presentacion.Page.Pacientes
{
    public class indexModel : PageModel
    {   
        private readonly IRepositoryPaciente _repoPaciente;
        public indexModel(IRepositoryPaciente _repoPaciente){
            this._repoPaciente = _repoPaciente;
        }

        public Paciente Paciente;
        public void OnGet(int id)
        {
            Paciente = _repoPaciente.GetPaciente(id);
        }
    }
}
