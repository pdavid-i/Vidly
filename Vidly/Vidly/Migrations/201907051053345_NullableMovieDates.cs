namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableMovieDates : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movie", "Released", c => c.DateTime());
            AlterColumn("dbo.Movie", "Added", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movie", "Added", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movie", "Released", c => c.DateTime(nullable: false));
        }
    }
}
