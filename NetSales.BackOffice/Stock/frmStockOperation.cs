using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSales.Entitys.DataAccess;
using NetSales.Entitys.Context;
using NetSales.Entitys;

namespace NetSales.BackOffice.Stock
{
    public partial class frmStockOperation : Form
    {
        private Entitys.Tables.Stock _entity; //data kaynağım burası.
        private StockDAL stockdal = new StockDAL();
        private NetSalesContext context = new NetSalesContext();
        public frmStockOperation(Entitys.Tables.Stock entity) //dependecy injection tasarım deseni
        {
            //Biçimlendirme Türleri
            //https://docs.microsoft.com/tr-tr/dotnet/standard/base-types/standard-numeric-format-strings
            InitializeComponent();
            _entity = entity;
            toggleStatus.DataBindings.Add("EditValue", _entity, "Status");
            txtStockCode.DataBindings.Add("Text", _entity, "StockCode");//datamember modelimdeki alan.
            txtStockName.DataBindings.Add("Text", _entity, "StockName");
            txtBarcode.DataBindings.Add("Text", _entity, "Barcode");
            cmbBarcode.DataBindings.Add("Text", _entity, "BarcodeType");
            btnUnit.DataBindings.Add("Text", _entity, "Unit");
            btnStockGroup.DataBindings.Add("Text", _entity, "StockGroup");
            btnStockSubGroup.DataBindings.Add("Text", _entity, "StockSubGroup");
            btnBrand.DataBindings.Add("Text", _entity, "Brand");
            btnModel.DataBindings.Add("Text", _entity, "Model");
            btnCustomCode1.DataBindings.Add("Text", _entity, "CustomCode1");
            btnCustomCode2.DataBindings.Add("Text", _entity, "CustomCode2");
            btnCustomCode3.DataBindings.Add("Text", _entity, "CustomCode3");
            btnCustomCode4.DataBindings.Add("Text", _entity, "CustomCode4");
            txtWarrantyTime.DataBindings.Add("Text", _entity, "WarrantyTime");
            txtManufacturerCode.DataBindings.Add("Text", _entity, "ManufacturerCode");
            txtBuyingKdv.DataBindings.Add("Text", _entity, "BuyingKdv");
            txtSaleKdv.DataBindings.Add("Text", _entity, "SalesKdv");
            calcBuying1.DataBindings.Add("EditValue", _entity, "BuyingPrice1");
            calcBuying2.DataBindings.Add("EditValue", _entity, "BuyingPrice2");
            calcBuying3.DataBindings.Add("EditValue", _entity, "BuyingPrice3");
            calcSalesPrice1.DataBindings.Add("EditValue", _entity, "SalesPrice1");
            calcSalesPrice2.DataBindings.Add("EditValue", _entity, "SalesPrice2");
            calcSalesPrice3.DataBindings.Add("EditValue", _entity, "SalesPrice3");
            
            calcMinStockQuantity.DataBindings.Add("EditValue", _entity, "MinStockQuantity");
            calcMinStockQuantity.DataBindings[0].FormattingEnabled = true;
            calcMinStockQuantity.DataBindings[0].FormatString = "N3";
            
            calcMaxStockQuantity.DataBindings.Add("EditValue", _entity, "MaxStockQuantity");
            calcMaxStockQuantity.DataBindings[0].FormattingEnabled = true;
            calcMaxStockQuantity.DataBindings[0].FormatString = "N3";

            txtComment.DataBindings.Add("Text", _entity, "Comment");
        }

        private void frmStockOperation_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            stockdal.AddOrUpdate(context, _entity);
            stockdal.Save(context);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
