namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "Genre", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "Genre");
        }
    }
}
