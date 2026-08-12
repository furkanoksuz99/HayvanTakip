namespace HayvanTakip.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IlkKurulum : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Isletmeler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsletmeNo = c.String(),
                        IsletmeAdi = c.String(),
                        IlKodu = c.String(),
                        IlceKodu = c.String(),
                        Adres = c.String(),
                        YetkiliTckn = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Isletmeler");
        }
    }
}
