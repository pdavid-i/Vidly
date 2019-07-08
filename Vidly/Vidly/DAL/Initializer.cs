using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Vidly.Models;
using Vidly.DAL;

namespace Vidly.DAL
{
    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            var students = new List<Movie>
            {
            new Movie{Id=3,Name="La vita e bella"},
            new Movie{Id=4,Name="City of God"},
            new Movie{Id=5,Name="Usual Suspects"},
            new Movie{Id=6,Name="Pi"},
            new Movie{Id=7,Name="Mud"},
            new Movie{Id=8,Name="Stuttgart"},
            new Movie{Id=9,Name="Drawg"}
            };

            students.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();
            var courses = new List<Customer>
            {
            new Customer{Id=10, Name="Tati"},
             new Customer{Id=11, Name="Mami"},
              new Customer{Id=12, Name="Tudi"},
               new Customer{Id=13, Name="Maria"},
                new Customer{Id=14, Name="Eu"}
            };
            courses.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
        }
    }
}