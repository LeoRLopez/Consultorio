using System;

namespace Consultorio.ViewModels
{
    public class TurnoVM
    {
        public string NombreCompleto { get; set; }
        public int PacienteId { get; set; }
        public Nullable<int> IdSeguroMedico { get; set; }
        public DateTime FechaHora { get; set; }
        public int IdMedico { get; set; }
        public bool FueAtendido { get; set; }
        public string NroDocumento { get; internal set; }
        public string Edad { get; internal set; }
        public string Telefono { get; internal set; }
    }
}