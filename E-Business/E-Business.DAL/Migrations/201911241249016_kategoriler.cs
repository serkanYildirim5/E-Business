namespace E_Business.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kategoriler : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AltKategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(nullable: false, maxLength: 30, unicode: false),
                        BagliOlduguKategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(maxLength: 40, unicode: false),
                        UrunFiyati = c.Double(nullable: false),
                        UrunFotografı = c.String(maxLength: 350, unicode: false),
                        UrunAdeti = c.Int(nullable: false),
                        UrunAciklama = c.String(maxLength: 200, unicode: false),
                        BagliOlduguKategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AltKategoriler", t => t.BagliOlduguKategoriId, cascadeDelete: true)
                .Index(t => t.BagliOlduguKategoriId);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Kategori_AltKategori_Islem",
                c => new
                    {
                        KategoriId = c.Int(nullable: false),
                        AltKategoriId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.KategoriId, t.AltKategoriId })
                .ForeignKey("dbo.Kategoriler", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.AltKategoriler", t => t.AltKategoriId, cascadeDelete: true)
                .Index(t => t.KategoriId)
                .Index(t => t.AltKategoriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kategori_AltKategori_Islem", "AltKategoriId", "dbo.AltKategoriler");
            DropForeignKey("dbo.Kategori_AltKategori_Islem", "KategoriId", "dbo.Kategoriler");
            DropForeignKey("dbo.Urunler", "BagliOlduguKategoriId", "dbo.AltKategoriler");
            DropIndex("dbo.Kategori_AltKategori_Islem", new[] { "AltKategoriId" });
            DropIndex("dbo.Kategori_AltKategori_Islem", new[] { "KategoriId" });
            DropIndex("dbo.Urunler", new[] { "BagliOlduguKategoriId" });
            DropTable("dbo.Kategori_AltKategori_Islem");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.Urunler");
            DropTable("dbo.AltKategoriler");
        }
    }
}
