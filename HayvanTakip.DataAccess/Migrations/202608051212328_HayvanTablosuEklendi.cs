namespace HayvanTakip.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HayvanTablosuEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hayvanlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KupeNo = c.String(),
                        IsletmeId = c.Int(nullable: false),
                        Tur = c.String(),
                        Irk = c.String(),
                        Cinsiyet = c.Int(nullable: false),
                        DogumTarihi = c.DateTime(nullable: false),
                        Durum = c.Int(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Isletmeler", t => t.IsletmeId, cascadeDelete: true)
                .Index(t => t.IsletmeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Hayvanlar", "IsletmeId", "dbo.Isletmeler");
            DropIndex("dbo.Hayvanlar", new[] { "IsletmeId" });
            DropTable("dbo.Hayvanlar");
        }
    }
}
