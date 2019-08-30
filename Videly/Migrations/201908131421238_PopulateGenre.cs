namespace Videly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres( Name) VALUES('Action')");
            Sql("INSERT INTO Genres( Name) VALUES('Romance')");
            Sql("INSERT INTO Genres( Name) VALUES('Horror')");
            Sql("INSERT INTO Genres( Name) VALUES('Drama')");
            Sql("INSERT INTO Genres( Name) VALUES('Science Friction')");
        }

        public override void Down()
        {
        }
    }
}
