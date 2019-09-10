using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entitys.Tables
{
    public class Case
    {
        public int Id { get; set; }
        public string CaseCode { get; set; }
        public string CaseName { get; set; }
        public string AuthorizedCode { get; set; }
        public string AuthorizedName { get; set; } // yetkili kodu
        public string Comment { get; set; }
    }
}
