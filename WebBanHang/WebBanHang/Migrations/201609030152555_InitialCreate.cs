namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CateID = c.Int(nullable: false, identity: true),
                        CateName = c.String(),
                    })
                .PrimaryKey(t => t.CateID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProID = c.Int(nullable: false, identity: true),
                        ProName = c.String(),
                        CateID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProID)
                .ForeignKey("dbo.Categories", t => t.CateID, cascadeDelete: true)
                .Index(t => t.CateID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CateID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CateID" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
