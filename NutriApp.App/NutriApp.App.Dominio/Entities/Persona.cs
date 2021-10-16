using System;

namespace NutriApp.App.Dominio{
    public class Persona{
        public int Id {get;set;}
        public string Nombre {get;set;}
        public DateTime FechaNacimiento {get;set;}
        public string Telefono {get;set;}
        public string Correo {get;set;}
        public string Password {get;set;}
    }
}
