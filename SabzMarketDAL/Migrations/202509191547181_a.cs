namespace SabzMarketDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sellers", "Address", c => c.String(nullable: false, maxLength: 500));
            DropColumn("dbo.Sellers", "Addres");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sellers", "Addres", c => c.String(nullable: false, maxLength: 500));
            DropColumn("dbo.Sellers", "Address");
        }
    }
}
