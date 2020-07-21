namespace MyRepor.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBasket : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BasketItems", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BasketItems", "Quantity", c => c.String());
        }
    }
}
