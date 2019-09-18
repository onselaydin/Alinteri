using NetSales.Entitys.Context;
using NetSales.Entitys.Repositories;
using NetSales.Entitys.Tables;
using NetSales.Entitys.Validations;
using System.Linq;

namespace NetSales.Entitys.DataAccess
{
    public class StockDAL:EntityRepositoryBase<NetSalesContext,Stock,StockValidator>
    {
       public object GetAllJoin(NetSalesContext context)
        {
            var table = context.Stocks.GroupJoin(context.StockLines, c => c.StockCode, c => c.StockCode, (Stocks, StockLines) =>
                 new
                 {
                     Stocks.Id,
                     Stocks.StockCode,
                     Stocks.StockName,
                     Stocks.Barcode,
                     Stocks.BarcodeType,
                     Stocks.Unit,
                     Stocks.StockGroup,
                     Stocks.StockSubGroup,
                     Stocks.Brand,
                     Stocks.Model,
                     Stocks.CustomCode1,
                     Stocks.CustomCode2,
                     Stocks.CustomCode3,
                     Stocks.CustomCode4,
                     Stocks.WarrantyTime,
                     Stocks.ManufacturerCode,
                     Stocks.BuyingKdv,
                     Stocks.BuyingPrice1,
                     Stocks.BuyingPrice2,
                     Stocks.BuyingPrice3,
                     Stocks.SalesPrice1,
                     Stocks.SalesPrice2,
                     Stocks.SalesPrice3,
                     Stocks.MinStockQuantity,
                     Stocks.MaxstockQuantity,
                     Stocks.Comment,
                     StockEntry = StockLines.Where(c => c.Line == "Stok Giriş").Sum(c => c.Amount) ?? 0,
                     StockExit = StockLines.Where(c => c.Line == "Stok Çıkış").Sum(c => c.Amount) ?? 0,
                     MevcutStok = StockLines.Where(c => c.Line == "Stok Giriş").Sum(c => c.Amount) -
                                 StockLines.Where(c => c.Line == "Stok Çıkış").Sum(c => c.Amount) ?? 0

                 }).ToList();
            return table;
        }
    }
}
