namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNameAndBday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "Birthday", c => c.DateTime());
            AddColumn("dbo.Membership", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Membership", "Name");
            DropColumn("dbo.Customer", "Birthday");
        }
    }
}
