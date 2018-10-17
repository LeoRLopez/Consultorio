using System;

namespace Consultorio.ViewModels
{
    public class PacienteTurnoVM
    {
        public int PacienteId { get; set; }
        public int TurnoId { get; set; }
        public int MedicoId { get; set; }
        public int FormaDePagoId { get; set; }
        public string PacienteNombreCompleto { get; set; }      
        public string FormaDePagoNombre { get; set; }
        public string MedicoNombreCompleto { get; set; }
        public DateTime FechaHoraTurno { get; set; }
        public string Edad { get; set; }
        public Nullable<int> IdSeguroMedico { get; set; }
        public string NombreSeguroMedico { get; set; }
        public bool Asistio { get; set; }
        public bool Atendido { get; set; }
        public string Descripcion { get; set; }
        public string Diagnostico { get; set; }
        public string Especialidad { get; set; }
    }
}