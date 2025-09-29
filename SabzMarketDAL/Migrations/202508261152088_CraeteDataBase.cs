namespace SabzMarketDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CraeteDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Chats",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Message = c.String(),
                        FormId_Id = c.Long(),
                        ToID_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.FormId_Id)
                .ForeignKey("dbo.Users", t => t.ToID_Id)
                .Index(t => t.FormId_Id)
                .Index(t => t.ToID_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 11, fixedLength: true, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        UserName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Password = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Farmers",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        UserId = c.Long(nullable: false),
                        Address = c.String(nullable: false, maxLength: 500),
                        DataBuilt = c.String(nullable: false, maxLength: 10, unicode: false),
                        LandArea = c.Int(nullable: false),
                        NationalCode = c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false),
                        CodParvaneBHB = c.String(nullable: false, maxLength: 50, unicode: false),
                        ProfileImage = c.String(nullable: false, maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SellerId = c.Long(nullable: false),
                        FarmerId = c.Long(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Farmers", t => t.FarmerId, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.SellerId, cascadeDelete: true)
                .Index(t => t.SellerId)
                .Index(t => t.FarmerId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        OrderId = c.Long(nullable: false),
                        ProductId = c.Long(nullable: false),
                        Number = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.OrderId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SellerId = c.Long(nullable: false),
                        CategorieId = c.Long(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 500),
                        Price = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        ImageProduct = c.String(nullable: false, maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategorieId, cascadeDelete: true)
                .ForeignKey("dbo.Sellers", t => t.SellerId, cascadeDelete: true)
                .Index(t => t.SellerId)
                .Index(t => t.CategorieId);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        Id = c.Long(nullable: false),
                        UserId = c.Long(nullable: false),
                        Address = c.String(nullable: false, maxLength: 500),
                        ProfileImage = c.String(maxLength: 4000),
                        WorkHistory = c.String(nullable: false, maxLength: 3, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chats", "ToID_Id", "dbo.Users");
            DropForeignKey("dbo.Chats", "FormId_Id", "dbo.Users");
            DropForeignKey("dbo.Farmers", "Id", "dbo.Users");
            DropForeignKey("dbo.OrderDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Sellers", "Id", "dbo.Users");
            DropForeignKey("dbo.Products", "SellerId", "dbo.Sellers");
            DropForeignKey("dbo.Orders", "SellerId", "dbo.Sellers");
            DropForeignKey("dbo.Products", "CategorieId", "dbo.Categories");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "FarmerId", "dbo.Farmers");
            DropIndex("dbo.Sellers", new[] { "Id" });
            DropIndex("dbo.Products", new[] { "CategorieId" });
            DropIndex("dbo.Products", new[] { "SellerId" });
            DropIndex("dbo.OrderDetails", new[] { "ProductId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "FarmerId" });
            DropIndex("dbo.Orders", new[] { "SellerId" });
            DropIndex("dbo.Farmers", new[] { "Id" });
            DropIndex("dbo.Chats", new[] { "ToID_Id" });
            DropIndex("dbo.Chats", new[] { "FormId_Id" });
            DropTable("dbo.Sellers");
            DropTable("dbo.Products");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.Farmers");
            DropTable("dbo.Users");
            DropTable("dbo.Chats");
            DropTable("dbo.Categories");
        }
    }
}
