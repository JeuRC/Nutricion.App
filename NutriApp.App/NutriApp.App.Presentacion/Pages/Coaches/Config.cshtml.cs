using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriApp.App.Persistencia;
using NutriApp.App.Dominio;

namespace NutriApp.App.Presentacion.Page.Coaches.Config
{
    public class ConfigModel : PageModel
    {
       private readonly IRepositoryCoach _repoCoach;
        public ConfigModel(IRepositoryCoach _repoCoach){
            this._repoCoach = _repoCoach;
        }

        [BindProperty]
        public Coach Coach {get;set;}
        private Coach CoachEdit;
        
        public void OnGet(int id)
        {
            Coach = _repoCoach.GetCoach(id);
        }

        public IActionResult OnPostEdit(){
            CoachEdit = _repoCoach.UpdateCoach(Coach);
            if(CoachEdit != null){
                return RedirectToPage("./index", new { id = CoachEdit.Id});
            }else{
                return Page();
            }
        }
    }
}
