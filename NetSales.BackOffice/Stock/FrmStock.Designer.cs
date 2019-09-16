namespace NetSales.BackOffice.Stock
{
    partial class FrmStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseTextOptions = true;
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTitle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblTitle.ImageOptions.Image")));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1297, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Stok Kartları";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnCopy);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnEdit);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 531);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1297, 86);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menü";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.ImageIndex = 0;
            this.btnAdd.ImageOptions.ImageList = this.imgMenu;
            this.btnAdd.Location = new System.Drawing.Point(12, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 34);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.ImageIndex = 3;
            this.btnEdit.ImageOptions.ImageList = this.imgMenu;
            this.btnEdit.Location = new System.Drawing.Point(136, 43);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(118, 34);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Düzenle";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.ImageIndex = 2;
            this.btnDelete.ImageOptions.ImageList = this.imgMenu;
            this.btnDelete.Location = new System.Drawing.Point(260, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Sil";
            // 
            // btnCopy
            // 
            this.btnCopy.ImageOptions.ImageIndex = 1;
            this.btnCopy.ImageOptions.ImageList = this.imgMenu;
            this.btnCopy.Location = new System.Drawing.Point(384, 43);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(118, 34);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Kopyala";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.ImageIndex = 4;
            this.btnUpdate.ImageOptions.ImageList = this.imgMenu;
            this.btnUpdate.Location = new System.Drawing.Point(508, 43);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 34);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Güncelle";
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.ImageIndex = 5;
            this.btnSearch.ImageOptions.ImageList = this.imgMenu;
            this.btnSearch.Location = new System.Drawing.Point(632, 43);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Ara";
            // 
            // imgMenu
            // 
            this.imgMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMenu.ImageStream")));
            this.imgMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMenu.Images.SetKeyName(0, "addStock.png");
            this.imgMenu.Images.SetKeyName(1, "copyStock.png");
            this.imgMenu.Images.SetKeyName(2, "deleteStock.png");
            this.imgMenu.Images.SetKeyName(3, "editStock.png");
            this.imgMenu.Images.SetKeyName(4, "refresh.png");
            this.imgMenu.Images.SetKeyName(5, "search.png");
            this.imgMenu.Images.SetKeyName(6, "close.png");
            this.imgMenu.Images.SetKeyName(7, "cancelFilter.png");
            this.imgMenu.Images.SetKeyName(8, "filter.png");
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.ImageIndex = 6;
            this.btnClose.ImageOptions.ImageList = this.imgMenu;
            this.btnClose.Location = new System.Drawing.Point(1167, 47);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Ara";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 80);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton3);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1297, 451);
            this.splitContainerControl1.SplitterPosition = 175;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1297, 269);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(1297, 175);
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.ImageIndex = 6;
            this.simpleButton1.ImageOptions.ImageList = this.imgMenu;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(1246, 131);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(39, 33);
            this.simpleButton1.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.ImageIndex = 7;
            this.simpleButton2.ImageOptions.ImageList = this.imgMenu;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(1196, 131);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(39, 33);
            this.simpleButton2.TabIndex = 1;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ImageOptions.ImageIndex = 8;
            this.simpleButton3.ImageOptions.ImageList = this.imgMenu;
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton3.Location = new System.Drawing.Point(1146, 131);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(39, 33);
            this.simpleButton3.TabIndex = 1;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 617);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmStock";
            this.Text = "Stok Kartları";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnCopy;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.ImageList imgMenu;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}