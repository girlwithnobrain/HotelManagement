﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class hotelEntities : DbContext
    {
        public hotelEntities()
            : base("name=hotelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<additional> additional { get; set; }
        public virtual DbSet<booking> booking { get; set; }
        public virtual DbSet<category> category { get; set; }
        public virtual DbSet<customer> customer { get; set; }
        public virtual DbSet<e> employee { get; set; }
        public virtual DbSet<extra> extra { get; set; }
        public virtual DbSet<reservation> reservation { get; set; }
        public virtual DbSet<room> room { get; set; }
        public virtual DbSet<service> service { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
