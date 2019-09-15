using NetSales.Entitys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entitys.Tables
{
    public class CaseLine:IEntity
    {
        public int Id { get; set; }
        public string SlipCode { get; set; }
        public string Line { get; set; } //hareket
        public string CaseCode { get; set; } //Kasa Kodu
        public string CaseName { get; set; } //Kasa Adı
        public string PaymentTypeCode { get; set; } //ödeme türü kodu
        public string PaymentTypeName { get; set; } //ödeme türü adı
        public string CurrentCode { get; set; } // cari kodu
        public string CurrentName { get; set; } // cari adı
        public DateTime DateTime { get; set; }
        public float Amount { get; set; } //tutar
        public string Aciklama { get; set; }
    }
}
