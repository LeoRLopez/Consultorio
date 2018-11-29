//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DepositoDeAlimentos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Presentado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Presentado()
        {
            this.Lote = new HashSet<Lote>();
            this.ReguladoPor = new HashSet<ReguladoPor>();
        }
    
        public int IdPresentado { get; set; }
        public int IdProducto { get; set; }
        public int IdEnvase { get; set; }
    
        public virtual Envase Envase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lote> Lote { get; set; }
        public virtual Producto Producto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReguladoPor> ReguladoPor { get; set; }
    }
}
