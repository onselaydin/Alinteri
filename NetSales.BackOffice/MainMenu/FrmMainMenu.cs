using NetSales.BackOffice.Stock;
using NetSales.Entitys.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetSales.BackOffice
{
    public partial class FrmMainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMainMenu()
        {
            InitializeComponent();
           
            using(var context=new NetSalesContext())
            {
                context.Database.CreateIfNotExists(); //veritabanı yoksa oluşturacak. Varsa pas geçecek.
            }

        }

        private void barbtnStok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStock form = new FrmStock();
            form.MdiParent = this;
            form.Show();

        }
    }
}
