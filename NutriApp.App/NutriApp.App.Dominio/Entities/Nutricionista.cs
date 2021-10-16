using System;
using System.Collections.Generic;

namespace NutriApp.App.Dominio{
    public class Nutricionista:Persona{
        public string Especializacion {get;set;}
        public string TarjetaProfesional {get;set;}
        public List<Paciente> Pacientes {get;set;}
    }
}