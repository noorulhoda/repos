﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace day1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MyCompanyEntities : DbContext
    {
        public MyCompanyEntities()
            : base("name=MyCompanyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<LapTop> LapTop { get; set; }
        public virtual DbSet<LapTopBrands> LapTopBrands { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<OrderHeader> OrderHeader { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<Smartphones> Smartphones { get; set; }
        public virtual DbSet<SmartphonesBrands> SmartphonesBrands { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
    }
}
