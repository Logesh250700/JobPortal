﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JobhuntDbEntities : DbContext
    {
        public JobhuntDbEntities()
            : base("name=JobhuntDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CompanyTable> CompanyTables { get; set; }
        public virtual DbSet<JobCategoryTable> JobCategoryTables { get; set; }
        public virtual DbSet<JobNatureTable> JobNatureTables { get; set; }
        public virtual DbSet<JobRequirementDetailTable> JobRequirementDetailTables { get; set; }
        public virtual DbSet<JobRequirementsTable> JobRequirementsTables { get; set; }
        public virtual DbSet<JobStatusTable> JobStatusTables { get; set; }
        public virtual DbSet<PostJobTable> PostJobTables { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }
        public virtual DbSet<UserTypeTable> UserTypeTables { get; set; }
    }
}
