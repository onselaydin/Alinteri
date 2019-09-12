using NetSales.Entitys.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSales.Entitys.Tables;
using System.Data.Entity.Migrations;
using System.Linq.Expressions;

namespace NetSales.Entitys.DataAccess
{
    public class StockDAL
    {
        public void AddOrUpdate(NetSalesContext context, Stock entity)
        {
            context.Stocks.AddOrUpdate(entity);
        }

        public void Delete(NetSalesContext context, Expression<Func<Stock, bool>> filter)
        {
            context.Stocks.RemoveRange(context.Stocks.Where(filter));
        }

        public void Save(NetSalesContext context)
        {
            context.SaveChanges();
        }
    }
}
