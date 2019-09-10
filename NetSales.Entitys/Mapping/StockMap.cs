using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSales.Entitys.Tables;

namespace NetSales.Entitys.Mapping
{
    public class StockMap:EntityTypeConfiguration<Stock>
    {
        //ctor yaz taba bas
        public StockMap()
        {
            this.HasKey(p => p.Id); // sql serverdaki primary keye tekabül ediyor.
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StockCode).HasMaxLength(12);
            this.Property(p => p.StockName).HasMaxLength(50);
            this.Property(p => p.Barcode).HasMaxLength(20);
            this.Property(p => p.BarcodeType).HasMaxLength(15);
            this.Property(p => p.Unit).HasMaxLength(15);
            this.Property(p => p.StockGroup).HasMaxLength(30);
            this.Property(p => p.Brand).HasMaxLength(30);
            this.Property(p => p.Model).HasMaxLength(30);
            this.Property(p => p.CustomCode1).HasMaxLength(30);
            this.Property(p => p.CustomCode2).HasMaxLength(30);
            this.Property(p => p.CustomCode3).HasMaxLength(30);
            this.Property(p => p.CustomCode4).HasMaxLength(30);
            this.Property(p => p.WarrantyTime).HasMaxLength(30);
            this.Property(p => p.ManufacturerCode).HasMaxLength(30);
            this.Property(p => p.BuyingPrice1).HasPrecision(12, 2); // decimal alan özellikleri
            this.Property(p => p.BuyingPrice2).HasPrecision(12, 2);
            this.Property(p => p.BuyingPrice3).HasPrecision(12, 2);
            this.Property(p => p.SalesPrice1).HasPrecision(12, 2);
            this.Property(p => p.SalesPrice2).HasPrecision(12, 2);
            this.Property(p => p.SalesPrice3).HasPrecision(12, 2);
            this.Property(p => p.MinStockQuantity).HasPrecision(12, 3);
            this.Property(p => p.MaxstockQuantity).HasPrecision(12, 3);
            this.Property(p => p.Comment).HasMaxLength(200);
            this.ToTable("Stocks");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Status).HasColumnName("Status");
            this.Property(p => p.StockCode).HasColumnName("StockCode");
            this.Property(p => p.StockName).HasColumnName("StockName");
            this.Property(p => p.Barcode).HasColumnName("Barcode");
            this.Property(p => p.BarcodeType).HasColumnName("BarcodeType");
            this.Property(p => p.Unit).HasColumnName("Unit");
            this.Property(p => p.StockGroup).HasColumnName("StockGroup");
            this.Property(p => p.StockSubGroup).HasColumnName("StockSubGroup");
            this.Property(p => p.Brand).HasColumnName("Brand");
            this.Property(p => p.Model).HasColumnName("Model");
            this.Property(p => p.CustomCode1).HasColumnName("CustomCode1");
            this.Property(p => p.CustomCode2).HasColumnName("CustomCode2");
            this.Property(p => p.CustomCode3).HasColumnName("CustomCode3");
            this.Property(p => p.CustomCode4).HasColumnName("CustomCode4");
            this.Property(p => p.WarrantyTime).HasColumnName("WarrantyTime");
            this.Property(p => p.ManufacturerCode).HasColumnName("ManufacturerCode");
            this.Property(p => p.BuyingKdv).HasColumnName("BuyingKdv");
            this.Property(p => p.SalesKdv).HasColumnName("SalesKdv");
            this.Property(p => p.Id).HasColumnName("Id");

        }
    }
}
