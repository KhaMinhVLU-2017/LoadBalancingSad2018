﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Candidate.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SAD2018Entities : DbContext
    {
        public SAD2018Entities()
            : base("name=SAD2018Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<chucvu> chucvus { get; set; }
        public virtual DbSet<contact> contacts { get; set; }
        public virtual DbSet<hopdonglaodong> hopdonglaodongs { get; set; }
        public virtual DbSet<loai> loais { get; set; }
        public virtual DbSet<luong> luongs { get; set; }
        public virtual DbSet<nhanvien> nhanviens { get; set; }
        public virtual DbSet<phieutuyendung> phieutuyendungs { get; set; }
        public virtual DbSet<phongban> phongbans { get; set; }
        public virtual DbSet<tinhtrang> tinhtrangs { get; set; }
        public virtual DbSet<tinhtrangdottuyendung> tinhtrangdottuyendungs { get; set; }
        public virtual DbSet<tinhtrangphieutuyendung> tinhtrangphieutuyendungs { get; set; }
        public virtual DbSet<trinhdohocvan> trinhdohocvans { get; set; }
        public virtual DbSet<tuyendung> tuyendungs { get; set; }
    }
}
