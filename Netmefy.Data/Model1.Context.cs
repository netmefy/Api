﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Netmefy.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NETMEFYEntities : DbContext
    {
        public NETMEFYEntities()
            : base("name=NETMEFYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bt_notificaciones> bt_notificaciones { get; set; }
        public virtual DbSet<bt_ord_trabajo> bt_ord_trabajo { get; set; }
        public virtual DbSet<bt_solicitudes> bt_solicitudes { get; set; }
        public virtual DbSet<bt_tests> bt_tests { get; set; }
        public virtual DbSet<cliente> clientes { get; set; }
        public virtual DbSet<router> routers { get; set; }
        public virtual DbSet<dispositivo> dispositivos { get; set; }
        public virtual DbSet<lk_empresa> lk_empresa { get; set; }
        public virtual DbSet<lk_estado> lk_estado { get; set; }
        public virtual DbSet<lk_localidad> lk_localidad { get; set; }
        public virtual DbSet<lk_notificacion> lk_notificacion { get; set; }
        public virtual DbSet<tecnico> tecnicos { get; set; }
        public virtual DbSet<lk_tiempo> lk_tiempo { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }
        public virtual DbSet<lk_web> lk_web { get; set; }
        public virtual DbSet<token> tokens { get; set; }
        public virtual DbSet<VW_Usuarios_App> VW_Usuarios_App { get; set; }
        public virtual DbSet<pagina> paginas { get; set; }
        public virtual DbSet<bt_os_status> bt_os_status { get; set; }
        public virtual DbSet<bt_ot_status> bt_ot_status { get; set; }
    }
}
