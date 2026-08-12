namespace HayvanTakip.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AsiTablosuEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asilar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HayvanId = c.Int(nullable: false),
                        AsiAdi = c.String(),
                        AsiTarihi = c.DateTime(nullable: false),
                        SonrakiAsiTarihi = c.DateTime(),
                        Aciklama = c.String(),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hayvanlar", t => t.HayvanId, cascadeDelete: true)
                .Index(t => t.HayvanId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Asilar", "HayvanId", "dbo.Hayvanlar");
            DropIndex("dbo.Asilar", new[] { "HayvanId" });
            DropTable("dbo.Asilar");
        }
    }
}
