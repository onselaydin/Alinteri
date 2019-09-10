using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entitys.Tables
{
    // fiş tablosu
    public class Slip
    {
        public int Id { get; set; }
        public string SlipCode { get; set; }
        public string SlipType { get; set; }
        public string CurrentCode { get; set; }
        public string CurrentName { get; set; }
        public string DocumentNo { get; set; }
        public DateTime Date { get; set; }
        public string SalesMan { get; set; } //Plasiyer, satış elemanı
        public string SalesManName { get; set; }
        public decimal DiscountRate { get; set; } //indirim 
        public decimal DiscountAmount { get; set; } //indirim tutarı
        public decimal TotalAmount { get; set; } // toplam tutar
        public string Comment { get; set; } // açıklama
    }
}
