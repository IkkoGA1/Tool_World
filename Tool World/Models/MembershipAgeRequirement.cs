using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tool_World.Models
{
    public class MembershipAgeRequirement : ValidationAttribute 
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

                if (customer.MembershipTypeId == MembershipType.Unknown || 
                    customer.MembershipTypeId == MembershipType.PayAsYouGo)
                    return ValidationResult.Success;

                if (customer.Birthdate == null)
                    return new ValidationResult("A birthdate is required.");

                var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

                return (age >= 18)
                    ? ValidationResult.Success
                    : new ValidationResult("Customer must be 18 years old for a membership with a fee.");
        }
    }
}