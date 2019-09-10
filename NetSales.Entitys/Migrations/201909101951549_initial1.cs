namespace NetSales.Entitys.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Current", "Web", c => c.String(maxLength: 90));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Current", "Web", c => c.String(maxLength: 50));
        }
    }
}
