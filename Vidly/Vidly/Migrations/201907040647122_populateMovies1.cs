namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMovies1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "Released", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movie", "Added", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movie", "inStock", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "inStock");
            DropColumn("dbo.Movie", "Added");
            DropColumn("dbo.Movie", "Released");
        }
    }
}
