using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSales.Entitys.Context;

namespace NetSales.BackOffice.Stock
{
    public partial class FrmStock : DevExpress.XtraEditors.XtraForm
    {
        NetSalesContext context = new NetSalesContext();
        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        public void GetAll()
        {
            var table = context.Stocks.GroupJoin(context.StockLines, c => c.StockCode, c => c.StockCode,(Stocks, StockLines) =>
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
                    StockEntry = StockLines.Where(c=>c.Line=="Stok Giriş").Sum(c=>c.Amount) ?? 0,
                    StockExit = StockLines.Where(c=>c.Line=="Stok Çıkış").Sum(c=>c.Amount) ?? 0,
                    MevcutStok = StockLines.Where(c => c.Line == "Stok Giriş").Sum(c => c.Amount) - 
                                StockLines.Where(c => c.Line == "Stok Çıkış").Sum(c => c.Amount) ?? 0

                }).ToList();
            gridControl1.DataSource = table;


        }
    }
}