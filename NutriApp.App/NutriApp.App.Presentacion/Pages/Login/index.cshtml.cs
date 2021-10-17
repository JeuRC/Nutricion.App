using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriApp.App.Persistencia;
using NutriApp.App.Dominio;

namespace NutriApp.App.Presentacion.Pages.Login{
    public class indexModel : PageModel{
        
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
        public Paciente Paciente{get;set;}
        public Nutricionista Nutricionista;
        public Coach Coach;

        public IActionResult OnPost(string Email, string Password){
            Paciente = _repoPaciente.LoginPaciente(Email, Password);
            Nutricionista = _repoNutricionista.LoginNutricionista(Email, Password);
            Coach = _repoCoach.LoginCoach(Email, Password);

            if(Paciente != null){
                return RedirectToPage("../Pacientes/index", new { id = Paciente.Id});
            }
            else if(Nutricionista != null){
                return RedirectToPage("../Nutricionistas/index", new { id = Nutricionista.Id});
            }
            else if(Coach != null){
                return RedirectToPage("../Coaches/index", new { id = Coach.Id});
            }
            else{
                 mensaje = "Datos incorrectos! ingresa un correo o contraseña correcta, o crea una cuenta";
                 return Page();
            }
        }
    }
}
