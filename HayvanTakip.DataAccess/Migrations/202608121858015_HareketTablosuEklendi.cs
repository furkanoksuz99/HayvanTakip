namespace HayvanTakip.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HareketTablosuEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hareketler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HayvanId = c.Int(nullable: false),
                        HareketTipi = c.Int(nullable: false),
                        KaynakIsletmeId = c.Int(),
                        HedefIsletmeId = c.Int(),
                        HareketTarihi = c.DateTime(nullable: false),
                        Aciklama = c.String(),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hayvanlar", t => t.HayvanId, cascadeDelete: true)
                .ForeignKey("dbo.Isletmeler", t => t.HedefIsletmeId)
                .ForeignKey("dbo.Isletmeler", t => t.KaynakIsletmeId)
                .Index(t => t.HayvanId)
                .Index(t => t.KaynakIsletmeId)
                .Index(t => t.HedefIsletmeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hareketler", "KaynakIsletmeId", "dbo.Isletmeler");
            DropForeignKey("dbo.Hareketler", "HedefIsletmeId", "dbo.Isletmeler");
            DropForeignKey("dbo.Hareketler", "HayvanId", "dbo.Hayvanlar");
            DropIndex("dbo.Hareketler", new[] { "HedefIsletmeId" });
            DropIndex("dbo.Hareketler", new[] { "KaynakIsletmeId" });
            DropIndex("dbo.Hareketler", new[] { "HayvanId" });
            DropTable("dbo.Hareketler");
        }
    }
}
