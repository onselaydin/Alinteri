using NetSales.Entitys.Context;
using NetSales.Entitys.Repositories;
using NetSales.Entitys.Tables;
using NetSales.Entitys.Validations;

namespace NetSales.Entitys.DataAccess
{
    public class CaseDAL:EntityRepositoryBase<NetSalesContext, Case, CaseValidator>
    {
    }
}
