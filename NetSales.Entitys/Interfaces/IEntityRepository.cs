using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSales.Entitys.Tables;
using NetSales.Entitys.Context;
using System.Linq.Expressions;
using System.Data.Entity;

namespace NetSales.Entitys.Interfaces
{
    public interface IEntityRepository<TContext,TEntity> 
        where TContext:DbContext,new()
        where TEntity:class,IEntity,new()
    {
        void AddOrUpdate(TContext context, TEntity entity);
        void Delete(TContext context, Expression<Func<TEntity, bool>> filter);
        void Save(TContext context);
    }
}
