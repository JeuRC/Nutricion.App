using System.Collections.Generic;
using System;
using System.Linq;
using NutriApp.App.Dominio;

namespace NutriApp.App.Persistencia{
    public class RepositoryPaciente : IRepositoryPaciente{
        private readonly AppContext _appContext = new AppContext();

        Paciente IRepositoryPaciente.AddPaciente(Paciente paciente){
            var pacienteAdicionado = _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }
        
        void IRepositoryPaciente.RemovePaciente(int idPaciente){
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p=>p.Id == idPaciente);
            if(pacienteEncontrado == null)return ;

            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();

        }

        Paciente IRepositoryPaciente.UpdatePaciente(Paciente paciente){
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p=>p.Id == paciente.Id);

            if(pacienteEncontrado != null){
                Console.WriteLine("{0}",pacienteEncontrado.Nombre);
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                pacienteEncontrado.Telefono = paciente.Telefono;
                pacienteEncontrado.Correo = paciente.Correo;
                pacienteEncontrado.Password = paciente.Password;
                pacienteEncontrado.Direccion = paciente.Direccion;
                pacienteEncontrado.Longitud = paciente.Longitud;
                pacienteEncontrado.Latitud = paciente.Latitud;
                _appContext.SaveChanges();
            }
                return pacienteEncontrado;
        }

        Paciente IRepositoryPaciente.GetPaciente(int idPaciente){
            return _appContext.Pacientes.FirstOrDefault(p=>p.Id == idPaciente);
        }

        IEnumerable<Paciente> IRepositoryPaciente.GetAllPacientes(){
            return _appContext.Pacientes;
        }

        Paciente IRepositoryPaciente.LoginPaciente(string email,string password){
            return _appContext.Pacientes.FirstOrDefault(p=>p.Correo == email && p.Password == password);
        }

        
    }

}