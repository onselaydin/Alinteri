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
    public class StockLineMap: EntityTypeConfiguration<StockLine>
    {
        public StockLineMap()
        {
            this.HasKey(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.SlipCode).HasMaxLength(12);
            this.Property(p => p.Line).HasMaxLength(10);
            this.Property(p => p.StockCode).HasMaxLength(12);
            this.Property(p => p.StockName).HasMaxLength(50);
            this.Property(p => p.Barcode).HasMaxLength(20);
            this.Property(p => p.BarcodeType).HasMaxLength(15);
            this.Property(p => p.Unit).HasMaxLength(15);
            this.Property(p => p.Amount).HasPrecision(12,3);
            this.Property(p => p.UnitPrice).HasPrecision(12,2);
            this.Property(p => p.DiscountRate).HasPrecision(12,2);
            this.Property(p => p.DiscountAmount).HasPrecision(12,2);
            this.Property(p => p.TotalAmount).HasPrecision(12,2);
            this.Property(p => p.WarehouseCode).HasMaxLength(12);
            this.Property(p => p.WarehouseName).HasMaxLength(30);
            this.Property(p => p.SerialNo).HasMaxLength(200);
            this.Property(p => p.Comment).HasMaxLength(200);
            this.ToTable("StockLine");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.SlipCode).HasColumnName("SlipCode");
            this.Property(p => p.Line).HasColumnName("StockCode");
            this.Property(p => p.StockName).HasColumnName("StockName");
            this.Property(p => p.BarcodeType).HasColumnName("BarcodeType");
            this.Property(p => p.Barcode).HasColumnName("Barcode");
            this.Property(p => p.Unit).HasColumnName("Unit");
            this.Property(p => p.Amount).HasColumnName("Amount");
            this.Property(p => p.Kdv).HasColumnName("Kdv");
            this.Property(p => p.UnitPrice).HasColumnName("UnitPrice");
            this.Property(p => p.DiscountRate).HasColumnName("DiscountRate");
            this.Property(p => p.DiscountAmount).HasColumnName("DiscountAmount");
            this.Property(p => p.TotalAmount).HasColumnName("TotalAmount");
            this.Property(p => p.WarehouseCode).HasColumnName("WarehouseCode");
            this.Property(p => p.WarehouseName).HasColumnName("WarehouseName");
            this.Property(p => p.SerialNo).HasColumnName("DateTime");
            this.Property(p => p.DateTime).HasColumnName("TotalAmount");
            this.Property(p => p.Comment).HasColumnName("Comment");

        }
    }
}
