namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSubscription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "Subscription", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "Subscription");
        }
    }
}
