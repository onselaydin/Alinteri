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
    public class SlipsMap: EntityTypeConfiguration<Slip>
    {
        public SlipsMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SlipCode).HasMaxLength(12);
            this.Property(p => p.SlipType).HasMaxLength(30);
            this.Property(p => p.CurrentCode).HasMaxLength(12);
            this.Property(p => p.CurrentName).HasMaxLength(50);
            this.Property(p => p.DocumentNo).HasMaxLength(20);
            this.Property(p => p.SalesMan).HasMaxLength(12);
            this.Property(p => p.SalesManName).HasMaxLength(50);
            this.Property(p => p.DiscountRate).HasPrecision(5,2);
            this.Property(p => p.DiscountRate).HasPrecision(12,2);
            this.Property(p => p.TotalAmount).HasPrecision(12,2);
            this.Property(p => p.Comment).HasMaxLength(200);
            this.ToTable("Slip");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.SlipCode).HasColumnName("SlipCode");
            this.Property(p => p.SlipType).HasColumnName("SlipType");
            this.Property(p => p.CurrentCode).HasColumnName("CurrentCode");
            this.Property(p => p.CurrentName).HasColumnName("CurrentName");
            this.Property(p => p.DocumentNo).HasColumnName("DocumentNo");
            this.Property(p => p.Date).HasColumnName("Date");
            this.Property(p => p.SalesMan).HasColumnName("SalesMan");
            this.Property(p => p.DiscountRate).HasColumnName("DiscountRate");
            this.Property(p => p.DiscountAmount).HasColumnName("DiscountAmount");
            this.Property(p => p.TotalAmount).HasColumnName("TotalAmount");
            this.Property(p => p.Comment).HasColumnName("Comment");
        }

    }
}
