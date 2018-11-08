﻿using System;

namespace Consultorio.ViewModels
{
    public class PersonalInternoVM
    {
        public int PersonalInternoId { get; set; }
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
    }
}