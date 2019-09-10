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
    public class PaymentTypeMap: EntityTypeConfiguration<PaymentType>
    {
        public PaymentTypeMap()
        {
            this.HasKey(p => p.Id); // sql serverdaki primary keye tekabül ediyor.
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.PaymentTypeCode).HasMaxLength(12);
            this.Property(p => p.PaymentTypeName).HasMaxLength(30);
            this.Property(p => p.Comment).HasMaxLength(200);
            this.ToTable("PaymentType");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.PaymentTypeCode).HasColumnName("PaymentTypeCode");
            this.Property(p => p.PaymentTypeName).HasColumnName("PaymentTypeName");
            this.Property(p => p.Comment).HasColumnName("Comment");
        }
    }
}
