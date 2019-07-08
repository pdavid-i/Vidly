using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class AddedAfterRelease : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            if (movie.Released == null || movie.Added == null)
                return ValidationResult.Success;
            return (movie.Released <= movie.Added)
                ? ValidationResult.Success
                : new ValidationResult("The movie cannot be added before it was released.");
        }

    }
}