﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DepositoEntities : DbContext
    {
        public DepositoEntities()
            : base("name=DepositoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<ClasificaEn> ClasificaEn { get; set; }
        public virtual DbSet<Envase> Envase { get; set; }
        public virtual DbSet<EstadoLote> EstadoLote { get; set; }
        public virtual DbSet<FichaInventario> FichaInventario { get; set; }
        public virtual DbSet<Incluye> Incluye { get; set; }
        public virtual DbSet<ListaVerificacion> ListaVerificacion { get; set; }
        public virtual DbSet<Lote> Lote { get; set; }
        public virtual DbSet<MarcoRegulatorio> MarcoRegulatorio { get; set; }
        public virtual DbSet<Presentado> Presentado { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ReguladoPor> ReguladoPor { get; set; }
        public virtual DbSet<Verificacion> Verificacion { get; set; }
    }
}
