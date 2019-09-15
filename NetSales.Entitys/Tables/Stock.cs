using NetSales.Entitys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entitys
{
    //Stok tablosu
    public class Stock:IEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string Barcode { get; set; }
        public string BarcodeType { get; set; }
        public string Unit { get; set; }
        public string StockGroup { get; set; }
        public string StockSubGroup { get; set; }
        public string Brand { get; set; } //Marka
        public string Model { get; set; }
        public string CustomCode1 { get; set; }
        public string CustomCode2 { get; set; }
        public string CustomCode3 { get; set; }
        public string CustomCode4 { get; set; }
        public string WarrantyTime { get; set; } // Garanti
        public string ManufacturerCode { get; set; } // üretici kodu
        public int BuyingKdv { get; set; } //Alış kdv
        public int SalesKdv { get; set; } // satış kdv
        public decimal BuyingPrice1 { get; set; } //Alış fiyatı
        public decimal BuyingPrice2 { get; set; }
        public decimal BuyingPrice3 { get; set; }
        public decimal SalesPrice1 { get; set; } //satış fiyatı
        public decimal SalesPrice2 { get; set; }
        public decimal SalesPrice3 { get; set; }
        public decimal MinStockQuantity { get; set; } //minimum stok  miktarı
        public decimal MaxstockQuantity { get; set; } //max stok miktarı
        public string Comment { get; set; }
    }
}
