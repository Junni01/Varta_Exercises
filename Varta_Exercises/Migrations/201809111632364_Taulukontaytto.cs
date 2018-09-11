namespace Varta_Exercises.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Taulukontaytto : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Tuotes (Kategoria, Nimi, Hinta, Kuvaus, Muokattu) VALUES ( 'Koje','POWERMAX 3000' ,1400, 'Ihan ok laite',CURRENT_TIMESTAMP)");
            Sql("INSERT INTO Tuotes (Kategoria, Nimi, Hinta, Kuvaus, Muokattu) VALUES ( 'Koje', 'Pesäpallopumppu',1005, 'Hyvä syksyisin', CURRENT_TIMESTAMP)");
            Sql("INSERT INTO Tuotes (Kategoria, Nimi, Hinta, Kuvaus, Muokattu) VALUES ( 'Laite', 'Haarukka' ,800, 'Hyödytön', CURRENT_TIMESTAMP)");
            Sql("INSERT INTO Tuotes (Kategoria, Nimi, Hinta, Kuvaus, Muokattu) VALUES ( 'Laite', 'GLX560 ZZ344',7600, '???', CURRENT_TIMESTAMP)");
            Sql("INSERT INTO Tuotes (Kategoria, Nimi, Hinta, Kuvaus, Muokattu) VALUES ( 'Vehje', 'Linnunpönttö harmaa vasenkätinen' ,9000, 'Erinomainen lahja anopille', CURRENT_TIMESTAMP)");
            Sql("INSERT INTO Tuotes (Kategoria, Nimi, Hinta, Kuvaus, Muokattu) VALUES ( 'Vehje', 'Raspberry PI 3',10, 'Huippuhyvä', CURRENT_TIMESTAMP)");

        }
        
        public override void Down()
        {
        }
    }
}
