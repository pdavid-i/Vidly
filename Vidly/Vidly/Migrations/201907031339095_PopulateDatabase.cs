﻿namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Membership (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO Membership (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO Membership (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (3, 90, 3, 20)");
            Sql("INSERT INTO Membership (Id, SignUpFee, DurationInMonths, DiscountRate) VALUES (4, 300, 12, 30)");
        }
        
        public override void Down()
        {
        }
    }
}
