using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
           
        [Required]
        public string Name { get; set; }

        public string Genre { get; set; }

        public DateTime? Released { get; set; }

        [AddedAfterRelease]
        public DateTime? Added {get; set;}

        [Range(1,100)]
        public byte inStock { get; set; }

        public string getReleased()
        {
            return String.Format("{0:y}", Released);
        }

        public string getAdded()
        {
            return String.Format("{0:y}", Added);
        }
    }
}