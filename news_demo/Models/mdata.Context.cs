﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace news_demo.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EFdataEntities : DbContext
    {
        public EFdataEntities()
            : base("name=EFdataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<film> films { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<video> videos { get; set; }
        public virtual DbSet<newsTop> newsTops { get; set; }
    }
}