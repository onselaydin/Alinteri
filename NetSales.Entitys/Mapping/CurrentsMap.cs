using NetSales.Entitys.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entitys.Mapping
{
    public class CurrentsMap: EntityTypeConfiguration<Current>
    {
        public CurrentsMap()
        {
            this.HasKey(p => p.Id); // sql serverdaki primary keye tekabül ediyor.
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.CurrentType).HasMaxLength(15);
            this.Property(p => p.CurrentCode).HasMaxLength(12);
            this.Property(p => p.CurrentName).HasMaxLength(50);
            this.Property(p => p.AuthorizedPerson).HasMaxLength(50);
            this.Property(p => p.InvoiceTitle).HasMaxLength(50);
            this.Property(p => p.GsmNumber).HasMaxLength(20);
            this.Property(p => p.Phone).HasMaxLength(20);
            this.Property(p => p.Fax).HasMaxLength(20);
            this.Property(p => p.EMail).HasMaxLength(50);
            this.Property(p => p.Web).HasMaxLength(100);
            this.Property(p => p.Province).HasMaxLength(20);
            this.Property(p => p.District).HasMaxLength(20);
            this.Property(p => p.Locality).HasMaxLength(20);
            this.Property(p => p.Address).HasMaxLength(100);
            this.Property(p => p.CurrentGroup).HasMaxLength(30);
            this.Property(p => p.CurrentSubGroup).HasMaxLength(30);
            this.Property(p => p.CustomCode1).HasMaxLength(30);
            this.Property(p => p.CustomCode2).HasMaxLength(30);
            this.Property(p => p.CustomCode3).HasMaxLength(30);
            this.Property(p => p.CustomCode4).HasMaxLength(30);
            this.Property(p => p.TaxOffice).HasMaxLength(30);
            this.Property(p => p.TaxNumber).HasMaxLength(15);
            this.Property(p => p.DiscountRate).HasPrecision(12,2);
            this.Property(p => p.RiskLimit).HasPrecision(12,2);
            this.Property(p => p.CustomBuyingPrice).HasPrecision(12,2);
            this.Property(p => p.CustomSalesPrice).HasPrecision(12,2);
            this.Property(p => p.Comment).HasMaxLength(200);
            this.ToTable("Current");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Status).HasColumnName("Status");
            this.Property(p => p.CurrentType).HasColumnName("CurrentType");
            this.Property(p => p.CurrentCode).HasColumnName("CurrentCode");
            this.Property(p => p.CurrentName).HasColumnName("CurrentName");
            this.Property(p => p.AuthorizedPerson).HasColumnName("AuthorizedPerson");
            this.Property(p => p.InvoiceTitle).HasColumnName("InvoiceTitle");
            this.Property(p => p.GsmNumber).HasColumnName("GsmNumber");
            this.Property(p => p.Phone).HasColumnName("Phone");
            this.Property(p => p.Fax).HasColumnName("Fax");
            this.Property(p => p.EMail).HasColumnName("EMail");
            this.Property(p => p.Web).HasColumnName("Web");
            this.Property(p => p.EMail).HasColumnName("EMail");
            this.Property(p => p.Province).HasColumnName("Province");
            this.Property(p => p.District).HasColumnName("District");
            this.Property(p => p.Locality).HasColumnName("Locality");
            this.Property(p => p.Address).HasColumnName("Address");
            this.Property(p => p.CurrentGroup).HasColumnName("CurrentGroup");
            this.Property(p => p.CurrentSubGroup).HasColumnName("CurrentSubGroup");
            this.Property(p => p.CustomCode1).HasColumnName("CustomCode1");
            this.Property(p => p.CustomCode2).HasColumnName("CustomCode2");
            this.Property(p => p.CustomCode3).HasColumnName("CustomCode3");
            this.Property(p => p.CustomCode4).HasColumnName("CustomCode4");
            this.Property(p => p.TaxOffice).HasColumnName("TaxOffice");
            this.Property(p => p.TaxNumber).HasColumnName("TaxNumber");
            this.Property(p => p.DiscountRate).HasColumnName("DiscountRate");
            this.Property(p => p.RiskLimit).HasColumnName("RiskLimit");
            this.Property(p => p.CustomBuyingPrice).HasColumnName("CustomBuyingPrice");
            this.Property(p => p.CustomSalesPrice).HasColumnName("CustomSalesPrice");
            this.Property(p => p.Comment).HasColumnName("Comment");
        }
    }
}
