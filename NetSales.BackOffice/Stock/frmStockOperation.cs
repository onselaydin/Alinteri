using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NetSales.BackOffice.Stock
{
    public partial class frmStockOperation : Form
    {
        private NetSales.Entitys.Tables.Stock _entity; //data kaynağım burası.
        public frmStockOperation(Entitys.Tables.Stock entity) //dependecy injection tasarım deseni
        {
            InitializeComponent();
            _entity = entity;
            toggleStatus.DataBindings.Add("Text", _entity, "Status");
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
            txtSaleKdv.DataBindings.Add("Text", _entity, "SaleKdv");
            calcBuying1.DataBindings.Add("Text", _entity, "BuyingPrice1");
            calcBuying2.DataBindings.Add("Text", _entity, "BuyingPrice2");
            calcBuying3.DataBindings.Add("Text", _entity, "BuyingPrice3");
            calcSalesPrice1.DataBindings.Add("Text", _entity, "SalesPrice1");
            calcSalesPrice2.DataBindings.Add("Text", _entity, "SalesPrice2");
            calcSalesPrice3.DataBindings.Add("Text", _entity, "SalesPrice3");
            calcMinStockQuantity.DataBindings.Add("Text", _entity, "MinStockQuantity");
            calcMaxStockQuantity.DataBindings.Add("Text", _entity, "MaxStockQuantity");
            txtComment.DataBindings.Add("Text", _entity, "Comment");
        }

        private void frmStockOperation_Load(object sender, EventArgs e)
        {

        }
    }
}
