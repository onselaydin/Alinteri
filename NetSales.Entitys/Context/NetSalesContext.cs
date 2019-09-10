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
            modelBuilder.Configurations.Add(new StocksMap());
            modelBuilder.Configurations.Add(new CurrentsMap());
            modelBuilder.Configurations.Add(new SlipsMap());
            modelBuilder.Configurations.Add(new StockLinesMap());
            modelBuilder.Configurations.Add(new CaseLinesMap());
            modelBuilder.Configurations.Add(new WarehousesMap());
            modelBuilder.Configurations.Add(new CasesMap());
            modelBuilder.Configurations.Add(new PaymentTypeMap());
            modelBuilder.Configurations.Add(new DefinationsMap());

        }

    }
}
