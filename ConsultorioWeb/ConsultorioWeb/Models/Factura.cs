//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsultorioWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            this.Turno = new HashSet<Turno>();
        }
    
        public int IdFactura { get; set; }
        public int IdTurno { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdFormaDePago { get; set; }
        public decimal Monto { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IdTarjeta { get; set; }
    
        public virtual FormaDePago FormaDePago { get; set; }
        public virtual Tarjetas Tarjetas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turno> Turno { get; set; }
    }
}
