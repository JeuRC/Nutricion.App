using System;

namespace NutriApp.App.Dominio{
    
    public class Seguimiento{
        public int Id {get;set;}
        public int HistorialId {get;set;}
        public DateTime Fecha {get;set;}
        public string Descripcion {get;set;}
    }
}