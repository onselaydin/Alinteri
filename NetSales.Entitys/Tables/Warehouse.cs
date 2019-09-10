using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entitys.Tables
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public string AuthorizedCode { get; set; } //yetkili kodu
        public string AuthorizedName { get; set; } //yetkili adı
        public string Province { get; set; }
        public string District { get; set; }
        public string Locality { get; set; } //semt
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Comment { get; set; }

    }
}
