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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.imgMenu = new System.Windows.Forms.ImageList(this.components);
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCopy = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBarcodeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockSubGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomCode2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomCode3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomCode4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarrantyTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colManufacturerCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyingKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesKdv = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyingPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyingPrice2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuyingPrice3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesPrice2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalesPrice3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMinStockQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaxstockQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockExit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMevcutStok = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.groupControl1.Location = new System.Drawing.Point(0, 519);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1297, 98);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menü";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.ImageIndex = 6;
            this.btnClose.ImageOptions.ImageList = this.imgMenu;
            this.btnClose.Location = new System.Drawing.Point(1167, 59);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Ara";
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
            // btnSearch
            // 
            this.btnSearch.ImageOptions.ImageIndex = 5;
            this.btnSearch.ImageOptions.ImageList = this.imgMenu;
            this.btnSearch.Location = new System.Drawing.Point(709, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 46);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Ara";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.ImageIndex = 4;
            this.btnUpdate.ImageOptions.ImageList = this.imgMenu;
            this.btnUpdate.Location = new System.Drawing.Point(569, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 46);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Güncelle";
            // 
            // btnCopy
            // 
            this.btnCopy.ImageOptions.ImageIndex = 1;
            this.btnCopy.ImageOptions.ImageList = this.imgMenu;
            this.btnCopy.Location = new System.Drawing.Point(429, 40);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(134, 46);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Kopyala";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.ImageIndex = 2;
            this.btnDelete.ImageOptions.ImageList = this.imgMenu;
            this.btnDelete.Location = new System.Drawing.Point(289, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 46);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Sil";
            // 
            // btnEdit
            // 
            this.btnEdit.ImageOptions.ImageIndex = 3;
            this.btnEdit.ImageOptions.ImageList = this.imgMenu;
            this.btnEdit.Location = new System.Drawing.Point(149, 40);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 46);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Düzenle";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.ImageIndex = 0;
            this.btnAdd.ImageOptions.ImageList = this.imgMenu;
            this.btnAdd.Location = new System.Drawing.Point(9, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1297, 439);
            this.splitContainerControl1.SplitterPosition = 107;
            this.splitContainerControl1.TabIndex = 2;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ImageOptions.ImageIndex = 8;
            this.simpleButton3.ImageOptions.ImageList = this.imgMenu;
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton3.Location = new System.Drawing.Point(1146, 63);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(39, 33);
            this.simpleButton3.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.ImageIndex = 7;
            this.simpleButton2.ImageOptions.ImageList = this.imgMenu;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(1196, 63);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(39, 33);
            this.simpleButton2.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.ImageIndex = 6;
            this.simpleButton1.ImageOptions.ImageList = this.imgMenu;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(1246, 63);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(39, 33);
            this.simpleButton1.TabIndex = 1;
            // 
            // filterControl1
            // 
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(1297, 107);
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1297, 325);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colStatus,
            this.colStockCode,
            this.colStockName,
            this.colBarcode,
            this.colBarcodeType,
            this.colUnit,
            this.colStockGroup,
            this.colStockSubGroup,
            this.colBrand,
            this.colModel,
            this.colCustomCode1,
            this.colCustomCode2,
            this.colCustomCode3,
            this.colCustomCode4,
            this.colWarrantyTime,
            this.colManufacturerCode,
            this.colBuyingKdv,
            this.colSalesKdv,
            this.colBuyingPrice1,
            this.colBuyingPrice2,
            this.colBuyingPrice3,
            this.colSalesPrice1,
            this.colSalesPrice2,
            this.colSalesPrice3,
            this.colMinStockQuantity,
            this.colMaxstockQuantity,
            this.colComment,
            this.colStockEntry,
            this.colStockExit,
            this.colMevcutStok});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 30;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Width = 112;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 30;
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowEdit = false;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 0;
            this.colStatus.Width = 112;
            // 
            // colStockCode
            // 
            this.colStockCode.FieldName = "StockCode";
            this.colStockCode.MinWidth = 30;
            this.colStockCode.Name = "colStockCode";
            this.colStockCode.OptionsColumn.AllowEdit = false;
            this.colStockCode.Visible = true;
            this.colStockCode.VisibleIndex = 1;
            this.colStockCode.Width = 112;
            // 
            // colStockName
            // 
            this.colStockName.FieldName = "StockName";
            this.colStockName.MinWidth = 30;
            this.colStockName.Name = "colStockName";
            this.colStockName.OptionsColumn.AllowEdit = false;
            this.colStockName.Visible = true;
            this.colStockName.VisibleIndex = 2;
            this.colStockName.Width = 112;
            // 
            // colBarcode
            // 
            this.colBarcode.FieldName = "Barcode";
            this.colBarcode.MinWidth = 30;
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.OptionsColumn.AllowEdit = false;
            this.colBarcode.Visible = true;
            this.colBarcode.VisibleIndex = 3;
            this.colBarcode.Width = 112;
            // 
            // colBarcodeType
            // 
            this.colBarcodeType.FieldName = "BarcodeType";
            this.colBarcodeType.MinWidth = 30;
            this.colBarcodeType.Name = "colBarcodeType";
            this.colBarcodeType.OptionsColumn.AllowEdit = false;
            this.colBarcodeType.Visible = true;
            this.colBarcodeType.VisibleIndex = 4;
            this.colBarcodeType.Width = 112;
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.MinWidth = 30;
            this.colUnit.Name = "colUnit";
            this.colUnit.OptionsColumn.AllowEdit = false;
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 5;
            this.colUnit.Width = 112;
            // 
            // colStockGroup
            // 
            this.colStockGroup.FieldName = "StockGroup";
            this.colStockGroup.MinWidth = 30;
            this.colStockGroup.Name = "colStockGroup";
            this.colStockGroup.OptionsColumn.AllowEdit = false;
            this.colStockGroup.Width = 116;
            // 
            // colStockSubGroup
            // 
            this.colStockSubGroup.FieldName = "StockSubGroup";
            this.colStockSubGroup.MinWidth = 30;
            this.colStockSubGroup.Name = "colStockSubGroup";
            this.colStockSubGroup.OptionsColumn.AllowEdit = false;
            this.colStockSubGroup.Width = 119;
            // 
            // colBrand
            // 
            this.colBrand.FieldName = "Brand";
            this.colBrand.MinWidth = 30;
            this.colBrand.Name = "colBrand";
            this.colBrand.OptionsColumn.AllowEdit = false;
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 6;
            this.colBrand.Width = 112;
            // 
            // colModel
            // 
            this.colModel.FieldName = "Model";
            this.colModel.MinWidth = 30;
            this.colModel.Name = "colModel";
            this.colModel.OptionsColumn.AllowEdit = false;
            this.colModel.Visible = true;
            this.colModel.VisibleIndex = 7;
            this.colModel.Width = 112;
            // 
            // colCustomCode1
            // 
            this.colCustomCode1.FieldName = "CustomCode1";
            this.colCustomCode1.MinWidth = 30;
            this.colCustomCode1.Name = "colCustomCode1";
            this.colCustomCode1.OptionsColumn.AllowEdit = false;
            this.colCustomCode1.Width = 112;
            // 
            // colCustomCode2
            // 
            this.colCustomCode2.FieldName = "CustomCode2";
            this.colCustomCode2.MinWidth = 30;
            this.colCustomCode2.Name = "colCustomCode2";
            this.colCustomCode2.OptionsColumn.AllowEdit = false;
            this.colCustomCode2.Width = 112;
            // 
            // colCustomCode3
            // 
            this.colCustomCode3.FieldName = "CustomCode3";
            this.colCustomCode3.MinWidth = 30;
            this.colCustomCode3.Name = "colCustomCode3";
            this.colCustomCode3.OptionsColumn.AllowEdit = false;
            this.colCustomCode3.Width = 112;
            // 
            // colCustomCode4
            // 
            this.colCustomCode4.FieldName = "CustomCode4";
            this.colCustomCode4.MinWidth = 30;
            this.colCustomCode4.Name = "colCustomCode4";
            this.colCustomCode4.OptionsColumn.AllowEdit = false;
            this.colCustomCode4.Width = 112;
            // 
            // colWarrantyTime
            // 
            this.colWarrantyTime.FieldName = "WarrantyTime";
            this.colWarrantyTime.MinWidth = 30;
            this.colWarrantyTime.Name = "colWarrantyTime";
            this.colWarrantyTime.OptionsColumn.AllowEdit = false;
            this.colWarrantyTime.Visible = true;
            this.colWarrantyTime.VisibleIndex = 8;
            this.colWarrantyTime.Width = 112;
            // 
            // colManufacturerCode
            // 
            this.colManufacturerCode.FieldName = "ManufacturerCode";
            this.colManufacturerCode.MinWidth = 30;
            this.colManufacturerCode.Name = "colManufacturerCode";
            this.colManufacturerCode.OptionsColumn.AllowEdit = false;
            this.colManufacturerCode.Visible = true;
            this.colManufacturerCode.VisibleIndex = 9;
            this.colManufacturerCode.Width = 112;
            // 
            // colBuyingKdv
            // 
            this.colBuyingKdv.FieldName = "BuyingKdv";
            this.colBuyingKdv.MinWidth = 30;
            this.colBuyingKdv.Name = "colBuyingKdv";
            this.colBuyingKdv.OptionsColumn.AllowEdit = false;
            this.colBuyingKdv.Visible = true;
            this.colBuyingKdv.VisibleIndex = 10;
            this.colBuyingKdv.Width = 112;
            // 
            // colSalesKdv
            // 
            this.colSalesKdv.FieldName = "SalesKdv";
            this.colSalesKdv.MinWidth = 30;
            this.colSalesKdv.Name = "colSalesKdv";
            this.colSalesKdv.OptionsColumn.AllowEdit = false;
            this.colSalesKdv.Visible = true;
            this.colSalesKdv.VisibleIndex = 11;
            this.colSalesKdv.Width = 112;
            // 
            // colBuyingPrice1
            // 
            this.colBuyingPrice1.FieldName = "BuyingPrice1";
            this.colBuyingPrice1.MinWidth = 30;
            this.colBuyingPrice1.Name = "colBuyingPrice1";
            this.colBuyingPrice1.OptionsColumn.AllowEdit = false;
            this.colBuyingPrice1.Width = 112;
            // 
            // colBuyingPrice2
            // 
            this.colBuyingPrice2.FieldName = "BuyingPrice2";
            this.colBuyingPrice2.MinWidth = 30;
            this.colBuyingPrice2.Name = "colBuyingPrice2";
            this.colBuyingPrice2.OptionsColumn.AllowEdit = false;
            this.colBuyingPrice2.Width = 112;
            // 
            // colBuyingPrice3
            // 
            this.colBuyingPrice3.FieldName = "BuyingPrice3";
            this.colBuyingPrice3.MinWidth = 30;
            this.colBuyingPrice3.Name = "colBuyingPrice3";
            this.colBuyingPrice3.OptionsColumn.AllowEdit = false;
            this.colBuyingPrice3.Width = 112;
            // 
            // colSalesPrice1
            // 
            this.colSalesPrice1.FieldName = "SalesPrice1";
            this.colSalesPrice1.MinWidth = 30;
            this.colSalesPrice1.Name = "colSalesPrice1";
            this.colSalesPrice1.OptionsColumn.AllowEdit = false;
            this.colSalesPrice1.Width = 112;
            // 
            // colSalesPrice2
            // 
            this.colSalesPrice2.FieldName = "SalesPrice2";
            this.colSalesPrice2.MinWidth = 30;
            this.colSalesPrice2.Name = "colSalesPrice2";
            this.colSalesPrice2.OptionsColumn.AllowEdit = false;
            this.colSalesPrice2.Width = 112;
            // 
            // colSalesPrice3
            // 
            this.colSalesPrice3.FieldName = "SalesPrice3";
            this.colSalesPrice3.MinWidth = 30;
            this.colSalesPrice3.Name = "colSalesPrice3";
            this.colSalesPrice3.OptionsColumn.AllowEdit = false;
            this.colSalesPrice3.Width = 112;
            // 
            // colMinStockQuantity
            // 
            this.colMinStockQuantity.FieldName = "MinStockQuantity";
            this.colMinStockQuantity.MinWidth = 30;
            this.colMinStockQuantity.Name = "colMinStockQuantity";
            this.colMinStockQuantity.OptionsColumn.AllowEdit = false;
            this.colMinStockQuantity.Width = 52;
            // 
            // colMaxstockQuantity
            // 
            this.colMaxstockQuantity.FieldName = "MaxstockQuantity";
            this.colMaxstockQuantity.MinWidth = 30;
            this.colMaxstockQuantity.Name = "colMaxstockQuantity";
            this.colMaxstockQuantity.OptionsColumn.AllowEdit = false;
            this.colMaxstockQuantity.Width = 81;
            // 
            // colComment
            // 
            this.colComment.FieldName = "Comment";
            this.colComment.MinWidth = 30;
            this.colComment.Name = "colComment";
            this.colComment.OptionsColumn.AllowEdit = false;
            this.colComment.Width = 94;
            // 
            // colStockEntry
            // 
            this.colStockEntry.Caption = "Stok Giriş";
            this.colStockEntry.FieldName = "StockEntry";
            this.colStockEntry.MinWidth = 30;
            this.colStockEntry.Name = "colStockEntry";
            this.colStockEntry.OptionsColumn.AllowEdit = false;
            this.colStockEntry.Visible = true;
            this.colStockEntry.VisibleIndex = 12;
            this.colStockEntry.Width = 112;
            // 
            // colStockExit
            // 
            this.colStockExit.Caption = "Stok Çıkış";
            this.colStockExit.FieldName = "StockExit";
            this.colStockExit.MinWidth = 30;
            this.colStockExit.Name = "colStockExit";
            this.colStockExit.OptionsColumn.AllowEdit = false;
            this.colStockExit.Visible = true;
            this.colStockExit.VisibleIndex = 13;
            this.colStockExit.Width = 112;
            // 
            // colMevcutStok
            // 
            this.colMevcutStok.Caption = "Mevcut Stok";
            this.colMevcutStok.FieldName = "MevcutStok";
            this.colMevcutStok.MinWidth = 30;
            this.colMevcutStok.Name = "colMevcutStok";
            this.colMevcutStok.OptionsColumn.AllowEdit = false;
            this.colMevcutStok.Visible = true;
            this.colMevcutStok.VisibleIndex = 14;
            this.colMevcutStok.Width = 112;
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
            this.Load += new System.EventHandler(this.FrmStock_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colStockCode;
        private DevExpress.XtraGrid.Columns.GridColumn colStockName;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcode;
        private DevExpress.XtraGrid.Columns.GridColumn colBarcodeType;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colStockGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colStockSubGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colModel;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomCode2;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomCode3;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomCode4;
        private DevExpress.XtraGrid.Columns.GridColumn colWarrantyTime;
        private DevExpress.XtraGrid.Columns.GridColumn colManufacturerCode;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyingKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesKdv;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyingPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyingPrice2;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyingPrice3;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesPrice2;
        private DevExpress.XtraGrid.Columns.GridColumn colSalesPrice3;
        private DevExpress.XtraGrid.Columns.GridColumn colMinStockQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colMaxstockQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colComment;
        private DevExpress.XtraGrid.Columns.GridColumn colStockEntry;
        private DevExpress.XtraGrid.Columns.GridColumn colStockExit;
        private DevExpress.XtraGrid.Columns.GridColumn colMevcutStok;
    }
}