namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMemberships : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Membership",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customer", "isSubscribed", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customer", "MembershipId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customer", "MembershipId");
            AddForeignKey("dbo.Customer", "MembershipId", "dbo.Membership", "Id", cascadeDelete: true);
            DropColumn("dbo.Customer", "Subscription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customer", "Subscription", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Customer", "MembershipId", "dbo.Membership");
            DropIndex("dbo.Customer", new[] { "MembershipId" });
            DropColumn("dbo.Customer", "MembershipId");
            DropColumn("dbo.Customer", "isSubscribed");
            DropTable("dbo.Membership");
        }
    }
}
