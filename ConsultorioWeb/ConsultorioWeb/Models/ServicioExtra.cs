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
    
    public partial class ServicioExtra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServicioExtra()
        {
            this.Turno = new HashSet<Turno>();
        }
    
        public int ServicioExtraId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turno> Turno { get; set; }
    }
}
