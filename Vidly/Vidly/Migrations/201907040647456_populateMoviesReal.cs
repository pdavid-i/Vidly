namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMoviesReal : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Movie(Name, Genre, Released, Added, inStock) VALUES ('Léon: The Professional', 'Action','1994-07-21T00:00:00.000', '2014-07-18T00:00:00.000', 7)");
            Sql("INSERT INTO Movie(Name, Genre, Released, Added, inStock) VALUES ('The Lord of the Rings: The Return of the King', 'Action','2003-07-21T00:00:00.000', '2012-09-28T00:00:00.000', 7)");
            Sql("INSERT INTO Movie(Name, Genre, Released, Added, inStock) VALUES ('Fight Club', 'Drama','1999-11-11T00:00:00.000', '2012-07-21T00:00:00.000', 7)");
            Sql("INSERT INTO Movie(Name, Genre, Released, Added, inStock) VALUES ('One Flew Over the Cuckoos Nest', 'Drama','1975-09-21T00:00:00.000', '2014-07-18T00:00:00.000', 7)");
            Sql("INSERT INTO Movie(Name, Genre, Released, Added, inStock) VALUES ('The Hangover', 'Comedy','2009-07-21T00:00:00.000', '2014-07-18T00:00:00.000', 7)");
            Sql("INSERT INTO Movie(Name, Genre, Released, Added, inStock) VALUES ('Female Jungle', 'Crime','1954-07-12T00:00:00.000', '2014-07-18T00:00:00.000', 7)");
            Sql("INSERT INTO Movie(Name, Genre, Released, Added, inStock) VALUES ('Sunset Blvd.', 'Film-Noir','1950-07-21T00:00:00.000', '2014-07-18T00:00:00.000', 7)");

        }

        public override void Down()
        {
        }
    }
}
