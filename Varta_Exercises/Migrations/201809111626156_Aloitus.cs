namespace Varta_Exercises.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Aloitus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tuotes",
                c => new
                    {
                        Tuotenumero = c.Int(nullable: false, identity: true),
                        Kategoria = c.String(),
                        Nimi = c.String(nullable: false),
                        Hinta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kuvaus = c.String(),
                        Muokattu = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Tuotenumero);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tuotes");
        }
    }
}
