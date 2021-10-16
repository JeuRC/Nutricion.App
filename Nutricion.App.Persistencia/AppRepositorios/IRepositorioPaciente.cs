using Nutricion.App.Dominio;

namespace Nutricion.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        Paciente AddPaciente(Paciente paciente);
        Paciente GetPaciente(int IdPaciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int IdPaciente);
    }
}