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
    
    public partial class Envase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Envase()
        {
            this.Presentado = new HashSet<Presentado>();
        }
    
        public int IdEnvase { get; set; }
        public Nullable<double> Peso { get; set; }
        public Nullable<double> Volumen { get; set; }
        public string Descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Presentado> Presentado { get; set; }
    }
}
