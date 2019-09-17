using NetSales.Entitys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entitys.Tables
{
    //cari tablosu
    public class Current:IEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string CurrentType { get; set; } // cari tipi
        public string CurrentCode { get; set; } // cari kodu
        public string CurrentName  { get; set; } // cari adı
        public string AuthorizedPerson { get; set; } //yetlişi kişi
        public string InvoiceTitle { get; set; } // fatura ünvanı
        public string GsmNumber { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string EMail { get; set; }
        public string Web { get; set; }
        public string Province { get; set; } //il
        public string District { get; set; } //ilçe
        public string Locality { get; set; } //semt
        public string Address { get; set; }
        public string CurrentGroup { get; set; }
        public string CurrentSubGroup { get; set; }
        public string CustomCode1 { get; set; }
        public string CustomCode2 { get; set; }
        public string CustomCode3 { get; set; }
        public string CustomCode4 { get; set; }
        public string TaxOffice { get; set; } //vergi Dairesi
        public string TaxNumber { get; set; } // Vergi numarası
        public decimal DiscountRate { get; set; } //iskonto oranı
        public decimal RiskLimit { get; set; }
        public decimal CustomBuyingPrice { get; set; } //Alış özel fiyatı
        public decimal CustomSalesPrice { get; set; } // Alış özel fiyatı
        public string Comment { get; set; } // Açıklama
    }
}
