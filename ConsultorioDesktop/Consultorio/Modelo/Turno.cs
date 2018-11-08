//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consultorio.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Turno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Turno()
        {
            this.LineaFactura = new HashSet<LineaFactura>();
        }
    
        public int IdTurno { get; set; }
        public int IdMedico { get; set; }
        public int IdPaciente { get; set; }
        public int IdFormaDePago { get; set; }
        public System.DateTime FechaYHora { get; set; }
        public Nullable<int> IdSeguroMedico { get; set; }
        public string Diagnostico { get; set; }
        public string Descripcion { get; set; }
        public bool Asistio { get; set; }
        public bool Atendido { get; set; }
        public decimal PrecioTurno { get; set; }
        public int IdEspecialidadMedico { get; set; }
    
        public virtual Especialidad Especialidad { get; set; }
        public virtual FormaDePago FormaDePago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LineaFactura> LineaFactura { get; set; }
        public virtual Medico Medico { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual SegurosMedico SegurosMedico { get; set; }
    }
}
