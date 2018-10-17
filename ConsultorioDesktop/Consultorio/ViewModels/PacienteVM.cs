using System;

namespace Consultorio.ViewModels
{
    public class PacienteVM
    {
        public int PacienteId { get; set; }
        public Nullable<int> IdHistoriaClinica { get; set; }
        public string NombreCompleto { get; set; }
        public string NroDocumento { get; set; }
        public string Edad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string AntecedentesMedicos { get; set; }
    }
}