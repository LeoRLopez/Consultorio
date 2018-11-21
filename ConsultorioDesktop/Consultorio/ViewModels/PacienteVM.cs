using System;
using System.Collections.Generic;

namespace Consultorio.ViewModels
{
    public class PacienteVM
    {
        public int PacienteId { get; set; }
        public List<int> IdHistoriasClinicas { get; set; }
        public string NombreCompleto { get; set; }
        public string NroDocumento { get; set; }
        public string Edad { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string AntecedentesMedicos { get; set; }
        public bool Donante { get;  set; }
        public bool Trasplantado { get; set; }
        public string GrupoSanguineo { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public int TurnoId { get; set; }
    }
}