namespace NetSales.Entitys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CaseLine",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SlipCode = c.String(maxLength: 12),
                        Line = c.String(maxLength: 10),
                        CaseCode = c.String(maxLength: 12),
                        CaseName = c.String(maxLength: 30),
                        PaymentTypeCode = c.String(maxLength: 12),
                        PaymentTypeName = c.String(maxLength: 30),
                        CurrentCode = c.String(),
                        CurrentName = c.String(),
                        DateTime = c.DateTime(nullable: false),
                        Amount = c.Single(nullable: false),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Case",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CaseCode = c.String(maxLength: 12),
                        CaseName = c.String(maxLength: 30),
                        AuthorizedCode = c.String(maxLength: 12),
                        AuthorizedName = c.String(maxLength: 50),
                        Comment = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Current",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                        CurrentType = c.String(maxLength: 15),
                        CurrentCode = c.String(maxLength: 12),
                        CurrentName = c.String(maxLength: 50),
                        AuthorizedPerson = c.String(maxLength: 50),
                        InvoiceTitle = c.String(maxLength: 50),
                        GsmNumber = c.String(maxLength: 20),
                        Phone = c.String(maxLength: 20),
                        Fax = c.String(maxLength: 20),
                        EMail = c.String(maxLength: 50),
                        Web = c.String(maxLength: 50),
                        Province = c.String(maxLength: 20),
                        District = c.String(maxLength: 20),
                        Locality = c.String(maxLength: 20),
                        Address = c.String(maxLength: 100),
                        CurrentGroup = c.String(maxLength: 30),
                        CurrentSubGroup = c.String(maxLength: 30),
                        CustomCode1 = c.String(maxLength: 30),
                        CustomCode2 = c.String(maxLength: 30),
                        CustomCode3 = c.String(maxLength: 30),
                        CustomCode4 = c.String(maxLength: 30),
                        TaxOffice = c.String(maxLength: 30),
                        TaxNumber = c.String(maxLength: 15),
                        DiscountRate = c.Decimal(nullable: false, precision: 12, scale: 2),
                        RiskLimit = c.Decimal(nullable: false, precision: 12, scale: 2),
                        CustomBuyingPrice = c.Decimal(nullable: false, precision: 12, scale: 2),
                        CustomSalesPrice = c.Decimal(nullable: false, precision: 12, scale: 2),
                        Comment = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Defination",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 15),
                        Def = c.String(maxLength: 30),
                        Comment = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentTypeCode = c.String(maxLength: 12),
                        PaymentTypeName = c.String(maxLength: 30),
                        Comment = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Slip",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SlipCode = c.String(maxLength: 12),
                        SlipType = c.String(maxLength: 30),
                        CurrentCode = c.String(maxLength: 12),
                        CurrentName = c.String(maxLength: 50),
                        DocumentNo = c.String(maxLength: 20),
                        Date = c.DateTime(nullable: false),
                        SalesMan = c.String(maxLength: 12),
                        SalesManName = c.String(maxLength: 50),
                        DiscountRate = c.Decimal(nullable: false, precision: 12, scale: 2),
                        DiscountAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalAmount = c.Decimal(nullable: false, precision: 12, scale: 2),
                        Comment = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StockLine",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SlipCode = c.String(maxLength: 12),
                        StockCode = c.String(maxLength: 10),
                        StockCode1 = c.String(maxLength: 12),
                        StockName = c.String(maxLength: 50),
                        BarcodeType = c.String(maxLength: 15),
                        Barcode = c.String(maxLength: 20),
                        Unit = c.String(maxLength: 15),
                        Amount = c.Decimal(nullable: false, precision: 12, scale: 3),
                        Kdv = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 12, scale: 2),
                        DiscountRate = c.Decimal(nullable: false, precision: 12, scale: 2),
                        DiscountAmount = c.Decimal(nullable: false, precision: 12, scale: 2),
                        TotalAmount = c.Decimal(nullable: false, precision: 12, scale: 2),
                        WarehouseCode = c.String(maxLength: 12),
                        WarehouseName = c.String(maxLength: 30),
                        SerialNo = c.String(maxLength: 200),
                        DateTime = c.DateTime(nullable: false),
                        Comment = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                        StockCode = c.String(maxLength: 12),
                        StockName = c.String(maxLength: 50),
                        Barcode = c.String(maxLength: 20),
                        BarcodeType = c.String(maxLength: 15),
                        Unit = c.String(maxLength: 15),
                        StockGroup = c.String(maxLength: 30),
                        StockSubGroup = c.String(),
                        Brand = c.String(maxLength: 30),
                        Model = c.String(maxLength: 30),
                        CustomCode1 = c.String(maxLength: 30),
                        CustomCode2 = c.String(maxLength: 30),
                        CustomCode3 = c.String(maxLength: 30),
                        CustomCode4 = c.String(maxLength: 30),
                        WarrantyTime = c.String(maxLength: 30),
                        ManufacturerCode = c.String(maxLength: 30),
                        BuyingKdv = c.Int(nullable: false),
                        SalesKdv = c.Int(nullable: false),
                        BuyingPrice1 = c.Decimal(nullable: false, precision: 12, scale: 2),
                        BuyingPrice2 = c.Decimal(nullable: false, precision: 12, scale: 2),
                        BuyingPrice3 = c.Decimal(nullable: false, precision: 12, scale: 2),
                        SalesPrice1 = c.Decimal(nullable: false, precision: 12, scale: 2),
                        SalesPrice2 = c.Decimal(nullable: false, precision: 12, scale: 2),
                        SalesPrice3 = c.Decimal(nullable: false, precision: 12, scale: 2),
                        MinStockQuantity = c.Decimal(nullable: false, precision: 12, scale: 3),
                        MaxstockQuantity = c.Decimal(nullable: false, precision: 12, scale: 3),
                        Comment = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Warehouse",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WarehouseCode = c.String(maxLength: 12),
                        WarehouseName = c.String(maxLength: 30),
                        AuthorizedCode = c.String(maxLength: 12),
                        AuthorizedName = c.String(maxLength: 50),
                        Province = c.String(maxLength: 20),
                        District = c.String(maxLength: 20),
                        Locality = c.String(maxLength: 20),
                        Address = c.String(maxLength: 100),
                        Phone = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Warehouse");
            DropTable("dbo.Stocks");
            DropTable("dbo.StockLine");
            DropTable("dbo.Slip");
            DropTable("dbo.PaymentType");
            DropTable("dbo.Defination");
            DropTable("dbo.Current");
            DropTable("dbo.Case");
            DropTable("dbo.CaseLine");
        }
    }
}
