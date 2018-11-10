using System;

namespace Consultorio
{
    internal class IniciarSesionEventArgs : EventArgs
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public bool EsAdministrador { get; set; }
        public Nullable<int> IdMedico { get; set; }
    }
}