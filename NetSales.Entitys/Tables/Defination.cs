using NetSales.Entitys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entitys.Tables
{
    public class Defination:IEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Def { get; set; }
        public string Comment { get; set; }

    }
}
