using System;
using System.Collections.Generic;

namespace Nutricion.App.Dominio
{
    public class Historia
    {
        public int Id {get;set;}
        public string NumeroRegistro {get;set;}
        public string Diagnostico {get;set;}
        public DateTime Fecha {get;set;}
        public List<SugerenciaCuidado> SugerenciasCuidados {get;set;}
        public List<Valoracion> Valoraciones {get;set;}
    }
}