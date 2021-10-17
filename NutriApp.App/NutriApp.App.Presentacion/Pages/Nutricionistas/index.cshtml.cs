using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriApp.App.Persistencia;
using NutriApp.App.Dominio;

namespace NutriApp.App.Presentacion.Page.Nutricionistas{
    public class indexModel:PageModel{
        private readonly IRepositoryNutricionista _repoNutricionista;
        public indexModel(IRepositoryNutricionista _repoNutricionista){
            this._repoNutricionista = _repoNutricionista;
        }

        public Nutricionista Nutricionista;
        public void OnGet(int id){
            Nutricionista = _repoNutricionista.GetNutricionista(id);
        }
    }
}
