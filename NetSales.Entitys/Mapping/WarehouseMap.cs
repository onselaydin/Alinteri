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
    public class WarehouseMap: EntityTypeConfiguration<Warehouse>
    {
        public WarehouseMap()
        {
            this.HasKey(p => p.Id); // sql serverdaki primary keye tekabül ediyor.
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.WarehouseCode).HasMaxLength(12);
            this.Property(p => p.WarehouseName).HasMaxLength(30);
            this.Property(p => p.AuthorizedCode).HasMaxLength(12);
            this.Property(p => p.AuthorizedName).HasMaxLength(50);
            this.Property(p => p.Province).HasMaxLength(20);
            this.Property(p => p.District).HasMaxLength(20);
            this.Property(p => p.Locality).HasMaxLength(20);
            this.Property(p => p.Address).HasMaxLength(100);
            this.ToTable("Warehouse");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(p => p.WarehouseName).HasColumnName("WarehouseName");
            this.Property(p => p.AuthorizedCode).HasColumnName("AuthorizedCode");
            this.Property(p => p.AuthorizedName).HasColumnName("AuthorizedName");
            this.Property(p => p.Province).HasColumnName("Province");
            this.Property(p => p.District).HasColumnName("District");
            this.Property(p => p.Locality).HasColumnName("Locality");
            this.Property(p => p.Address).HasColumnName("Address");
            this.Property(p => p.Phone).HasColumnName("Phone");
            this.Property(p => p.Comment).HasColumnName("Comment");

        }
    }
}
