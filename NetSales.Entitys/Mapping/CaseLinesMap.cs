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
    public class CaseLinesMap: EntityTypeConfiguration<CaseLine>
    {
        public CaseLinesMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SlipCode).HasMaxLength(12);
            this.Property(p => p.Line).HasMaxLength(10);
            this.Property(p => p.CaseCode).HasMaxLength(12);
            this.Property(p => p.CaseName).HasMaxLength(30);
            this.Property(p => p.PaymentTypeCode).HasMaxLength(12);
            this.Property(p => p.PaymentTypeName).HasMaxLength(30);
            this.ToTable("CaseLine");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.SlipCode).HasColumnName("SlipCode");
            this.Property(p => p.Line).HasColumnName("Line");
            this.Property(p => p.CaseCode).HasColumnName("CaseCode");
            this.Property(p => p.CaseName).HasColumnName("CaseName");
            this.Property(p => p.PaymentTypeCode).HasColumnName("PaymentTypeCode");
            this.Property(p => p.PaymentTypeName).HasColumnName("PaymentTypeName");
            this.Property(p => p.CurrentCode).HasColumnName("CurrentCode");
            this.Property(p => p.CurrentName).HasColumnName("CurrentName");
            this.Property(p => p.DateTime).HasColumnName("DateTime");
            this.Property(p => p.Amount).HasColumnName("Amount");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
