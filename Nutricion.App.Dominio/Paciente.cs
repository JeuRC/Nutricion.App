using System;
using System.Collections.Generic;

namespace Nutricion.App.Dominio
{
    public class Paciente : Persona
    {
        public DateTime FechaNacimiento { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Ciudad {get;set;}
        public Genero Genero { get; set; }
        public Coach Coach {get;set;}
        public Nutricionista Nutricionista {get;set;}
        public Historia Historia {get;set;}
        public List<SugerenciaCuidado> SugerenciasCuidados {get;set;}
        public List<Valoracion> Valoraciones {get;set;}
    }
}