using System;

namespace NutriApp.App.Dominio{
    
    public class Historial{
        public int Id {get;set;}
        public int PacienteId {get;set;}
        public float Carbohidratos {get;set;}
        public float Proteinas {get;set;}
        public float Grasas {get;set;}
        public float Peso {get;set;}
        public float Estatura {get;set;}
        public Seguimiento Seguimiento {get;set;}
    }
}