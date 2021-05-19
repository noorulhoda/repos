using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcDay2.Models
{
    public class productExisted:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext v)
        {
            MyCompanyEntities c = new MyCompanyEntities();
            if (c.Products.FirstOrDefault(predicate => predicate.Name == value.ToString()) != null)
                return new ValidationResult("product existed");
            return ValidationResult.Success;
        }
    }
}