using System;

namespace Nutricion.App.Dominio
{
    public class SugerenciaCuidado
    {
        public int Id {get;set;}
        public DateTime Fecha {get;set;}
        public string Tipo {get;set;}
        public string Descripcion {get;set;}
    }
}