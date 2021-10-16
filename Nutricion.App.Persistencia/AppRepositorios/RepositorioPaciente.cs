using Nutricion.App.Dominio;

namespace Nutricion.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext=new AppContext();
        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado=_appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }
        Paciente IRepositorioPaciente.GetPaciente(int IdPaciente)
        {
            return _appContext.Pacientes.Find(IdPaciente);
        }

        Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado=_appContext.Pacientes.Find(paciente.Id);
            if (pacienteEncontrado!=null)
            {
                pacienteEncontrado.Nombre=paciente.Nombre;
                pacienteEncontrado.Apellidos=paciente.Apellidos;
                pacienteEncontrado.Correo=paciente.Correo;
                pacienteEncontrado.Telefono=paciente.Telefono;
                pacienteEncontrado.Contraseña=paciente.Contraseña;
                pacienteEncontrado.Identificacion=paciente.Identificacion;
                pacienteEncontrado.Genero=paciente.Genero;
                pacienteEncontrado.Latitud=paciente.Latitud;
                pacienteEncontrado.Longitud=paciente.Longitud;
                pacienteEncontrado.Ciudad=paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento=paciente.FechaNacimiento;
                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }

        void IRepositorioPaciente.DeletePaciente(int IdPaciente)
        {
            var pacienteEncontrado=_appContext.Pacientes.Find(IdPaciente);
            if (pacienteEncontrado!=null)
            {
                _appContext.Pacientes.Remove(pacienteEncontrado);
                _appContext.SaveChanges();
            }
        }
    }
}