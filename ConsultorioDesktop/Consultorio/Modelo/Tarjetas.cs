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
    
    public partial class Tarjetas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tarjetas()
        {
            this.Bancos_Tarjetas = new HashSet<Bancos_Tarjetas>();
            this.Paciente_Tarjetas = new HashSet<Paciente_Tarjetas>();
        }
    
        public int IdTarjeta { get; set; }
        public string Titular { get; set; }
        public string NumeroTarjeta { get; set; }
        public System.DateTime FechaVto { get; set; }
        public int IdBanco { get; set; }
        public bool BajaLogica { get; set; }
        public string NombreTarjeta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bancos_Tarjetas> Bancos_Tarjetas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paciente_Tarjetas> Paciente_Tarjetas { get; set; }
    }
}
