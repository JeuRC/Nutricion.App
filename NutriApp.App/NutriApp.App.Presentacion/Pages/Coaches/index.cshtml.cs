using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NutriApp.App.Persistencia;
using NutriApp.App.Dominio;

namespace NutriApp.App.Presentacion.Page.Coaches
{
    public class indexModel : PageModel
    {
        private readonly IRepositoryCoach _repoCoach;
        public indexModel(IRepositoryCoach _repoCoach){
            this._repoCoach = _repoCoach;
        }

        public Coach Coach;
        public void OnGet(int id){
            Coach = _repoCoach.GetCoach(id);
        }
    }
}

