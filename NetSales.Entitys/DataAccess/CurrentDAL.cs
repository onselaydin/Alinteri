using NetSales.Entitys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSales.Entitys.Tables;
using NetSales.Entitys.Context;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;
using NetSales.Entitys.Repositories;
using NetSales.Entitys.Validations;

namespace NetSales.Entitys.DataAccess
{
    public class CurrentDAL: EntityRepositoryBase<NetSalesContext, Current,CurrentValidator>
    {
        
    }
}
