﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetSales.Entitys.Tables;

namespace NetSales.Entitys.Mapping
{
    public class DefinationsMap: EntityTypeConfiguration<Defination>
    {
        public DefinationsMap()
        {
            this.HasKey(p => p.Id); // sql serverdaki primary keye tekabül ediyor.
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Type).HasMaxLength(15);
            this.Property(p => p.Def).HasMaxLength(30);
            this.Property(p => p.Comment).HasMaxLength(200);
            this.ToTable("Defination");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Type).HasColumnName("Type");
            this.Property(p => p.Def).HasColumnName("Def");
            this.Property(p => p.Comment).HasColumnName("Comment");
        }
    }
}
