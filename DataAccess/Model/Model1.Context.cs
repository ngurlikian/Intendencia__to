﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDToledoEntities : DbContext
    {
        public BDToledoEntities()
            : base("name=BDToledoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cuadrilla> Cuadrilla { get; set; }
        public virtual DbSet<HistorialReclamo> HistorialReclamo { get; set; }
        public virtual DbSet<Reclamo> Reclamo { get; set; }
        public virtual DbSet<TipoDeReclamo> TipoDeReclamo { get; set; }
        public virtual DbSet<UbicacionZona> UbicacionZona { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<Zona> Zona { get; set; }
    }
}
