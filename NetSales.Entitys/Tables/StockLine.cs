﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entitys.Tables
{
    public class StockLine
    {
        public int Id { get; set; }
        public string SlipCode { get; set; }
        public string Line { get; set; } //hareket
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string BarcodeType { get; set; }
        public string Barcode { get; set; }
        public string Unit { get; set; } // birim
        public decimal Amount { get; set; } //miktar
        public int Kdv { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountRate { get; set; } //indirim oranı
        public decimal DiscountAmount { get; set; } //indirim Tutarı
        public decimal TotalAmount { get; set; } //toplam tutar
        public string WarehouseCode { get; set; } //depo kodu
        public string WarehouseName { get; set; }
        public string SerialNo { get; set; } //seri numarası
        public DateTime DateTime { get; set; }
        public string Comment { get; set; }
    }
}