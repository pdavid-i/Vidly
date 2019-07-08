namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Customer (Name, isSubscribed, MembershipId,Birthday) VALUES ('Dave Roster', 1, 2,'1998-07-18T00:00:00.000')");
            Sql("INSERT INTO Customer (Name, isSubscribed, MembershipId,Birthday) VALUES ('Delia Melaine', 0, 3,'1968-03-02T00:00:00.000')");
            Sql("INSERT INTO Customer (Name, isSubscribed, MembershipId,Birthday) VALUES ('John Antoine', 0, 3,'1968-11-23T00:00:00.000')");
            Sql("INSERT INTO Customer (Name, isSubscribed, MembershipId,Birthday) VALUES ('Theodor Purpy', 1, 2,'2002-01-22T00:00:00.000')");
            Sql("INSERT INTO Customer (Name, isSubscribed, MembershipId,Birthday) VALUES ('Mary Jane', 1, 1,'2002-01-22T00:00:00.000')");

        }

        public override void Down()
        {
        }
    }
}
