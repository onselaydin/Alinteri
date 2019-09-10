using NetSales.Entitys.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSales.Entitys.Mapping;

namespace NetSales.Entitys.Context
{
    public class NetSalesContext:DbContext
    {
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<Slip> Slips { get; set; }
        public DbSet<StockLine> StockLines { get; set; }
        public DbSet<CaseLine> CaseLines { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Defination> Definations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StockMap());
            modelBuilder.Configurations.Add(new CurrentMap());
            modelBuilder.Configurations.Add(new SlipMap());
            modelBuilder.Configurations.Add(new StockLineMap());
            modelBuilder.Configurations.Add(new CaseLineMap());
            modelBuilder.Configurations.Add(new WarehouseMap());
            modelBuilder.Configurations.Add(new CaseMap());
            modelBuilder.Configurations.Add(new PaymentTypeMap());
            modelBuilder.Configurations.Add(new DefinationMap());

        }

    }
}
