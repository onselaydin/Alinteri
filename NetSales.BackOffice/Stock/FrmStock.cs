using DevExpress.XtraEditors;
using NetSales.Entitys.Context;
using NetSales.Entitys.DataAccess;
using System;
using System.Windows.Forms;

namespace NetSales.BackOffice.Stock
{
    public partial class FrmStock : DevExpress.XtraEditors.XtraForm
    {
        NetSalesContext context = new NetSalesContext();
        StockDAL stock = new StockDAL();

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

            
            gridControl1.DataSource = stock.GetAllJoin(context);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //filtreyi iptal eder.
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void btnFilterClose_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Seçili olan veriyi silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //stock.Delete(context, c => c.StockCode == gridView1.GetFocusedRowCellValue(colStockCode).ToString());
                string selected = gridView1.GetFocusedRowCellValue(colStockCode).ToString();
                stock.Delete(context, c => c.StockCode == selected);
                stock.Save(context);
                GetAll();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmStockOperation so = new frmStockOperation();
            so.Show();
        }
    }
}