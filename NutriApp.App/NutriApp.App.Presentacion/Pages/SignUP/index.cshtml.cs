using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriApp.App.Persistencia;
using NutriApp.App.Dominio;

namespace NutriApp.App.Presentacion.Pages.SignUp
{
    public class indexModel : PageModel
    {
        private readonly IRepositoryPaciente _repoPaciente;
        private readonly IRepositoryNutricionista _repoNutricionista;
        private readonly IRepositoryCoach _repoCoach;

        public indexModel(IRepositoryPaciente _repoPaciente, IRepositoryNutricionista _repoNutricionista, IRepositoryCoach _repoCoach){
            this._repoPaciente = _repoPaciente;
            this._repoNutricionista = _repoNutricionista;
            this._repoCoach = _repoCoach;
        }

        public string mensaje {set;get;}
        [BindProperty]
        public Paciente Paciente {get;set;}
        [BindProperty]
        public Nutricionista Nutricionista {get;set;}
        [BindProperty]
        public Coach Coach {get;set;}

        public IActionResult OnPost(string nameUser,string dateUser, string telefonoUser, string emailUser, string passwordUser, string userType)
        {
            if(userType == "paciente"){
                Paciente.Nombre = nameUser;
                Paciente.FechaNacimiento  = DateTime.Parse(dateUser);
                Paciente.Telefono = telefonoUser;
                Paciente.Correo = emailUser;
                Paciente.Password = passwordUser;
                var PacienteAdd = _repoPaciente.AddPaciente(Paciente);
                return RedirectToPage("../Pacientes/index", new { id = PacienteAdd.Id});
            }
            else if(userType == "nutricionista"){
                Nutricionista.Nombre = nameUser;
                Nutricionista.FechaNacimiento  = DateTime.Parse(dateUser);
                Nutricionista.Telefono = telefonoUser;
                Nutricionista.Correo = emailUser;
                Nutricionista.Password = passwordUser;
                var NutricionistaAdd = _repoNutricionista.AddNutricionista(Nutricionista);
                return RedirectToPage("Nutricionista/index", new { id = NutricionistaAdd.Id});
            }
            else if(userType == "coach"){
                Coach.Nombre = nameUser;
                Coach.FechaNacimiento  = DateTime.Parse(dateUser);
                Coach.Telefono = telefonoUser;
                Coach.Correo = emailUser;
                Coach.Password = passwordUser;
                var CoachAdd = _repoCoach.AddCoach(Coach);
                return RedirectToPage("Coach/index", new { id = CoachAdd.Id});
            }else{
                return Page();
            }
        }
    }
}
