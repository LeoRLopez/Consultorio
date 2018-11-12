using System;

namespace Consultorio.ViewModels
{
    public class FacturaTurnoVM
    {
        public int IdFactura { get; set; }
        public int IdTurno { get; set; }
        public int IdPaciente { get; set; }
        public string PacienteNombreCompleto { get; set; }
        public int IdMedico { get; set; }
        public string MedicoNombreCompleto { get; set; }
        public DateTime FechaFactura { get; set; }
        public DateTime FechaTurno { get; set; }
        public int IdFormaDePago { get; set; }
        public string FormaDePago { get; set; }
        public decimal MontoFactura { get; set; }
        public string DescripcionFactura { get; set; }
        public int? IdTarjeta { get; set; }
        public string TarjetaNombre { get; set; }
    }
}