using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using NetSales.Entitys.Tables;

namespace NetSales.Entitys.Mapping
{
    public class CaseMap: EntityTypeConfiguration<Case>
    {
        public CaseMap()
        {
            this.HasKey(p => p.Id); // sql serverdaki primary keye tekabül ediyor.
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.CaseCode).HasMaxLength(12);
            this.Property(p => p.CaseName).HasMaxLength(30);
            this.Property(p => p.AuthorizedCode).HasMaxLength(12);
            this.Property(p => p.AuthorizedName).HasMaxLength(50);
            this.Property(p => p.Comment).HasMaxLength(200);
            this.ToTable("Case");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.CaseCode).HasColumnName("CaseCode");
            this.Property(p => p.CaseName).HasColumnName("CaseName");
            this.Property(p => p.AuthorizedCode).HasColumnName("AuthorizedCode");
            this.Property(p => p.AuthorizedName).HasColumnName("AuthorizedName");
            this.Property(p => p.Comment).HasColumnName("Comment");

        }
    }
}
