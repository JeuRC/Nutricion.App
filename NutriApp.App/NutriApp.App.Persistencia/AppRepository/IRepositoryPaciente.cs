using System.Collections.Generic;
using NutriApp.App.Dominio;

namespace NutriApp.App.Persistencia{
    public interface IRepositoryPaciente{
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void RemovePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
        Paciente LoginPaciente(string email,string password);
    }
} 