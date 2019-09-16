using NetSales.Entitys.Context;
using NetSales.Entitys.Repositories;
using NetSales.Entitys.Tables;
using NetSales.Entitys.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entitys.DataAccess
{
    public class DefinationDAL: EntityRepositoryBase<NetSalesContext, Defination,DefinationValidator>
    {
    }
}
