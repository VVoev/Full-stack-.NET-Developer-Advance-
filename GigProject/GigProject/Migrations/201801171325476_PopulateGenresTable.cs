namespace GigProject.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (ID,NAME) VALUES (1,'Techno')");
            Sql("INSERT INTO GENRES (ID,NAME) VALUES (2,'Rap')");
            Sql("INSERT INTO GENRES (ID,NAME) VALUES (3,'Chalga')");
            Sql("INSERT INTO GENRES (ID,NAME) VALUES (4,'Rock')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM GENRES WHERE Id IN (1,2,3,4)");
        }
    }
}
