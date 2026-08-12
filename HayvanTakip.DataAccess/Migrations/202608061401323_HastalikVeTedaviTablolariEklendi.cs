namespace HayvanTakip.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HastalikVeTedaviTablolariEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hastaliklar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HayvanId = c.Int(nullable: false),
                        HastalikAdi = c.String(),
                        TeshisTarihi = c.DateTime(nullable: false),
                        Belirtiler = c.String(),
                        Aciklama = c.String(),
                        DevamEdiyorMu = c.Boolean(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hayvanlar", t => t.HayvanId, cascadeDelete: true)
                .Index(t => t.HayvanId);
            
            CreateTable(
                "dbo.Tedaviler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HastalikId = c.Int(nullable: false),
                        TedaviAdi = c.String(),
                        IlacAdi = c.String(),
                        BaslangicTarihi = c.DateTime(nullable: false),
                        BitisTarihi = c.DateTime(),
                        DozBilgisi = c.String(),
                        Aciklama = c.String(),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hastaliklar", t => t.HastalikId, cascadeDelete: true)
                .Index(t => t.HastalikId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tedaviler", "HastalikId", "dbo.Hastaliklar");
            DropForeignKey("dbo.Hastaliklar", "HayvanId", "dbo.Hayvanlar");
            DropIndex("dbo.Tedaviler", new[] { "HastalikId" });
            DropIndex("dbo.Hastaliklar", new[] { "HayvanId" });
            DropTable("dbo.Tedaviler");
            DropTable("dbo.Hastaliklar");
        }
    }
}
