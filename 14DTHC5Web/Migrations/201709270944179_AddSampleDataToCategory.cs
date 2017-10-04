namespace _14DTHC5Web.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddSampleDataToCategory : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(1,'DEVELOPMENT')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(2,'MARKETING ONLINE')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES(3,'DESIGN')");
        }

        public override void Down()
        {
        }
    }
}
