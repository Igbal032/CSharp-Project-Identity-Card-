﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IdentitySearchEntities : DbContext
    {
        public IdentitySearchEntities()
            : base("name=IdentitySearchEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BloodGroup> BloodGroups { get; set; }
        public virtual DbSet<EyeColor> EyeColors { get; set; }
        public virtual DbSet<FamilyStatu> FamilyStatus { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<MilitaryStatuss> MilitaryStatusses { get; set; }
        public virtual DbSet<Nationality> Nationalitys { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
