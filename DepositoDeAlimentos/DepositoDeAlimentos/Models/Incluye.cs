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
    
    public partial class Incluye
    {
        public int IdIncluye { get; set; }
        public string NroMarcoRegulatorio { get; set; }
        public int IdVerificacion { get; set; }
        public string NombreTecnico { get; set; }
    
        public virtual Verificacion Verificacion { get; set; }
        public virtual MarcoRegulatorio MarcoRegulatorio { get; set; }
    }
}
