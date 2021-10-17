using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriApp.App.Persistencia;
using NutriApp.App.Dominio;

namespace NutriApp.App.Presentacion.Page.Nutricionistas.Config
{
    public class ConfigModel : PageModel
    {
       private readonly IRepositoryNutricionista _repoNutricionista;
        public ConfigModel(IRepositoryNutricionista _repoNutricionista){
            this._repoNutricionista = _repoNutricionista;
        }

        [BindProperty]
        public Nutricionista Nutricionista {get;set;}
        private Nutricionista NutricionistaEdit;
        
        public void OnGet(int id)
        {
            Nutricionista = _repoNutricionista.GetNutricionista(id);
        }

        public IActionResult OnPostEdit(){
            NutricionistaEdit = _repoNutricionista.UpdateNutricionista(Nutricionista);
            if(NutricionistaEdit != null){
                return RedirectToPage("./index", new { id = NutricionistaEdit.Id});
            }else{
                return Page();
            }
        }
    }
}
