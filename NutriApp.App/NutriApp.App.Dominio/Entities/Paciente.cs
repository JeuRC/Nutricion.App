using System;
using System.Collections.Generic;

namespace NutriApp.App.Dominio{
    public class Paciente:Persona{
        public string Direccion {get;set;}
        public string Latitud {get;set;}
        public string Longitud {get;set;}
        public Coach Coach {get;set;}
        public List<Historial> Historial {get;set;}
    }
}