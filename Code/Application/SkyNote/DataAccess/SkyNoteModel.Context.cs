﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class skynotedbEntities1 : DbContext
    {
        public skynotedbEntities1()
            : base("name=skynotedbEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<group> group { get; set; }
        public DbSet<location> location { get; set; }
        public DbSet<note> note { get; set; }
        public DbSet<user> user { get; set; }
        public DbSet<usergroup> usergroup { get; set; }
    }
}
