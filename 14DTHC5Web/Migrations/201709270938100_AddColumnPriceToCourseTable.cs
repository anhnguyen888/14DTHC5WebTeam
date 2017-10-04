namespace _14DTHC5Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnPriceToCourseTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Price", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Price");
        }
    }
}
