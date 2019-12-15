namespace E_Business.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yorumlar : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Yorumlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 40, unicode: false),
                        Email = c.String(maxLength: 100, unicode: false),
                        Number = c.String(maxLength: 11, unicode: false),
                        Comment = c.String(maxLength: 300, unicode: false),
                        BagliOlduguUrunId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Urunler", t => t.BagliOlduguUrunId, cascadeDelete: true)
                .Index(t => t.BagliOlduguUrunId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorumlar", "BagliOlduguUrunId", "dbo.Urunler");
            DropIndex("dbo.Yorumlar", new[] { "BagliOlduguUrunId" });
            DropTable("dbo.Yorumlar");
        }
    }
}
