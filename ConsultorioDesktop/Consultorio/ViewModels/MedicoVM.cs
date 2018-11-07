using System.Collections.Generic;
using System.Linq;

namespace Consultorio.ViewModels
{
    public class MedicoVM
    {
        public int MedicoId { get; set; }
        public string NombreCompleto { get; set; }
        public string LunesHorario { get; set; }
        public string MartesHorario { get; set; }
        public string MiercolesHorario { get; set; }
        public string JuevesHorario { get; set; }
        public string ViernesHorario { get; set; }
        public string SabadoHorario { get; set; }
        public string DomingoHorario { get; set; }
        public List<EspecialidadMedicoVM> EspecialidadesMedicoVM { get; set; }
        public string NombrarEspecialidades
        {
            get { return string.Join(", ", EspecialidadesMedicoVM.Select(x => x.NombrePrecio).ToArray()); }
        }
    }
}